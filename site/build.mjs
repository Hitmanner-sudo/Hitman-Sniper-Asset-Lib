// Builds the static file browser into an output folder (default: _site).
//   node site/build.mjs [outDir] [--no-thumbs]
// - Scans ../public and writes manifest.json (path, size, image dimensions)
// - Generates small WebP thumbnails so phones don't download full textures
// - Copies index.html / style.css / app.js
// Asset files themselves are NOT copied (public/ is >1 GB, over the Pages limit).
// On GitHub Actions they are streamed from jsDelivr / raw.githubusercontent.com
// pinned to the built commit; locally they load from ../public/.
import fs from 'node:fs/promises';
import path from 'node:path';
import { fileURLToPath } from 'node:url';

const here = path.dirname(fileURLToPath(import.meta.url));
const root = path.resolve(here, '..');
const publicDir = path.join(root, 'public');
const args = process.argv.slice(2);
const outDir = path.resolve(root, args.find(a => !a.startsWith('--')) || '_site');
const wantThumbs = !args.includes('--no-thumbs');
const THUMB = 320;
const IMG = /\.(png|jpe?g|gif|webp|bmp|tga)$/i;

let sharp = null;
if (wantThumbs) {
  try { sharp = (await import('sharp')).default; }
  catch { console.warn('sharp not installed: skipping thumbnails (npm i sharp)'); }
}

async function walk(dir, rel = '') {
  const out = [];
  for (const e of await fs.readdir(dir, { withFileTypes: true })) {
    if (e.name.startsWith('.')) continue;
    const r = rel ? `${rel}/${e.name}` : e.name;
    if (e.isDirectory()) out.push(...await walk(path.join(dir, e.name), r));
    else if (e.isFile()) out.push(r);
  }
  return out;
}

function pngSize(buf) {
  if (buf.length > 24 && buf.toString('ascii', 1, 4) === 'PNG') return [buf.readUInt32BE(16), buf.readUInt32BE(20)];
  return null;
}

const rels = (await walk(publicDir)).sort((a, b) => a.localeCompare(b));
await fs.rm(outDir, { recursive: true, force: true });
await fs.mkdir(path.join(outDir, 'thumbs'), { recursive: true });

const files = [];
let thumbs = 0, i = 0;
const queue = [...rels];
async function worker() {
  while (queue.length) {
    const rel = queue.shift();
    const abs = path.join(publicDir, rel);
    const st = await fs.stat(abs);
    const entry = { p: rel, s: st.size };
    if (IMG.test(rel)) {
      try {
        if (sharp) {
          const img = sharp(abs, { limitInputPixels: false });
          const meta = await img.metadata();
          entry.w = meta.width; entry.h = meta.height;
          const t = path.join(outDir, 'thumbs', rel.replace(/\.[^.]+$/, '.webp'));
          await fs.mkdir(path.dirname(t), { recursive: true });
          await img.resize(THUMB, THUMB, { fit: 'inside', withoutEnlargement: true }).webp({ quality: 72, alphaQuality: 80 }).toFile(t);
          entry.t = 1; thumbs++;
        } else {
          const fh = await fs.open(abs); const buf = Buffer.alloc(32);
          await fh.read(buf, 0, 32, 0); await fh.close();
          const d = pngSize(buf); if (d) [entry.w, entry.h] = d;
        }
      } catch (err) { console.warn(`thumb failed: ${rel}: ${err.message}`); }
    }
    files.push(entry);
    if (++i % 200 === 0) console.log(`${i}/${rels.length}`);
  }
}
await Promise.all(Array.from({ length: 4 }, worker));
files.sort((a, b) => a.p.localeCompare(b.p));

const repo = process.env.GITHUB_REPOSITORY;
const sha = process.env.GITHUB_SHA;
const base = repo && sha
  ? { cdn: `https://cdn.jsdelivr.net/gh/${repo}@${sha}/public/`, raw: `https://raw.githubusercontent.com/${repo}/${sha}/public/`, cdnMax: 20 * 1024 * 1024 }
  : { cdn: '../public/', raw: '../public/', cdnMax: Infinity };
const manifest = { generated: new Date().toISOString(), repo: repo || null, commit: sha || null, base, files };
await fs.writeFile(path.join(outDir, 'manifest.json'), JSON.stringify(manifest));
for (const f of ['index.html', 'style.css', 'app.js', 'favicon.svg']) await fs.copyFile(path.join(here, f), path.join(outDir, f));
await fs.writeFile(path.join(outDir, '.nojekyll'), '');
console.log(`Built ${files.length} files (${thumbs} thumbnails) into ${path.relative(root, outDir) || '.'}`);
