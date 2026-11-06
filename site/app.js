(() => {
  'use strict';
  const $ = (s) => document.querySelector(s);
  const IMG = /\.(png|jpe?g|gif|webp|bmp|svg|tga)$/i;
  const AUD = /\.(ogg|mp3|wav|m4a|aac|flac|opus)$/i;
  const CHUNK = 120;
  const GROUP_MIN_FOLDER = 24; // auto-group a folder once it has more files than this
  const GROUP_MIN_SIZE = 4;    // smallest auto-created sub-folder
  const MAX_DEPTH = 3;

  const el = {
    tree: $('#tree'), crumbs: $('#crumbs'), folders: $('#folders'), files: $('#files'), sentinel: $('#sentinel'),
    empty: $('#empty'), loading: $('#loading'), summary: $('#summary'), stats: $('#stats'),
    search: $('#search'), searchClear: $('#searchClear'), sort: $('#sort'),
    typeFilter: $('#typeFilter'), viewToggle: $('#viewToggle'),
    sidebar: $('#sidebar'), scrim: $('#scrim'), menuBtn: $('#menuBtn'),
    viewer: $('#viewer'), vStage: $('#vStage'), vImg: $('#vImg'), vThumb: $('#vThumb'), vSpin: $('#vSpin'),
    vName: $('#vName'), vMeta: $('#vMeta'), vCount: $('#vCount'), vOpen: $('#vOpen'),
    player: $('#player'), seek: $('#seek'), pPlay: $('#pPlay'), pName: $('#pName'), pTime: $('#pTime'), pVol: $('#pVol'),
    toast: $('#toast'),
  };

  const prefs = load('prefs', { view: 'grid', sort: 'name', type: 'all', vol: 1, expanded: [] });
  const state = {
    manifest: null, root: null, nodes: new Map(), byPath: new Map(), all: [],
    cur: null, query: '', list: [], rendered: 0,
    expanded: new Set(prefs.expanded),
    viewer: { idx: -1, list: [], pushed: false, bg: 0, zoom: false },
    audio: { el: new Audio(), list: [], idx: -1, file: null },
  };

  // ---------- helpers ----------
  function load(k, d) { try { return Object.assign({}, d, JSON.parse(localStorage.getItem('hsa:' + k))); } catch { return d; } }
  function save() { prefs.expanded = [...state.expanded]; try { localStorage.setItem('hsa:prefs', JSON.stringify(prefs)); } catch {} }
  function esc(s) { return String(s).replace(/[&<>"']/g, (c) => ({ '&': '&amp;', '<': '&lt;', '>': '&gt;', '"': '&quot;', "'": '&#39;' }[c])); }
  function fmtSize(b) { if (b == null) return ''; const u = ['B', 'KB', 'MB', 'GB']; let i = 0; while (b >= 1024 && i < 3) { b /= 1024; i++; } return (i ? b.toFixed(b < 10 ? 1 : 0) : b) + ' ' + u[i]; }
  function fmtNum(n) { return n.toLocaleString('en-US'); }
  function fmtTime(s) { if (!isFinite(s)) return '0:00'; s = Math.floor(s); return Math.floor(s / 60) + ':' + String(s % 60).padStart(2, '0'); }
  const enc = (p) => p.split('/').map(encodeURIComponent).join('/');
  const dec = (p) => p.split('/').map((s) => { try { return decodeURIComponent(s); } catch { return s; } }).join('/');
  function url(f, forceRaw) {
    const b = state.manifest.base;
    return (forceRaw || f.s > b.cdnMax ? b.raw : b.cdn) + enc(f.p);
  }
  function thumbUrl(f) { return f.t ? 'thumbs/' + enc(f.p.replace(/\.[^.]+$/, '.webp')) : url(f); }
  function dims(f) { return f.w ? `${f.w}×${f.h}` : ''; }
  function highlight(text) {
    const s = esc(text);
    if (!state.query) return s;
    const terms = state.query.split(/\s+/).filter(Boolean).map((t) => t.replace(/[.*+?^${}()|[\]\\]/g, '\\$&'));
    return terms.length ? s.replace(new RegExp(`(${terms.join('|')})`, 'gi'), '<mark>$1</mark>') : s;
  }
  let toastT;
  function toast(msg) { el.toast.textContent = msg; el.toast.classList.add('show'); clearTimeout(toastT); toastT = setTimeout(() => el.toast.classList.remove('show'), 1800); }
  function setRange(r) { r.style.setProperty('--p', ((r.value - r.min) / (r.max - r.min)) * 100 + '%'); }

  // ---------- tree ----------
  function makeNode(name, path, parent, virtual = false) {
    const n = { name, path, parent, virtual, folders: [], files: [], count: 0, size: 0, images: 0, audio: 0 };
    state.nodes.set(path, n);
    return n;
  }

  function tokens(f) { return f.base.split(/[_\-. ]+/).filter(Boolean); }

  // Split a big flat folder into sub-folders by filename prefix (NPC_*, icon_*, sfx_weapon_* ...)
  function autoGroup(node, depth) {
    if (node.files.length <= GROUP_MIN_FOLDER || depth > MAX_DEPTH) return;
    const buckets = new Map();
    for (const f of node.files) {
      const t = tokens(f);
      if (t.length <= depth + 1) continue; // nothing left after this token: keep file here
      const key = t[depth].toLowerCase();
      if (!buckets.has(key)) buckets.set(key, []);
      buckets.get(key).push(f);
    }
    for (const k of [...buckets.keys()]) { // merge plurals: weapons -> weapon
      if (k.length > 3 && k.endsWith('s') && buckets.has(k.slice(0, -1))) {
        buckets.get(k.slice(0, -1)).push(...buckets.get(k)); buckets.delete(k);
      }
    }
    const groups = [...buckets.entries()].filter(([, fs]) => fs.length >= GROUP_MIN_SIZE);
    if (!groups.length) return;
    if (groups.length === 1 && groups[0][1].length === node.files.length) return autoGroup(node, depth + 1); // shared prefix
    const taken = new Set(node.folders.map((c) => c.name.toLowerCase()));
    for (const [key, fs] of groups) {
      const casing = new Map();
      for (const f of fs) { const t = tokens(f)[depth]; casing.set(t, (casing.get(t) || 0) + 1); }
      let name = [...casing.entries()].sort((a, b) => b[1] - a[1])[0][0];
      if (/^[a-z]/.test(name) && name.length > 3) name = name[0].toUpperCase() + name.slice(1);
      if (taken.has(name.toLowerCase())) continue;
      taken.add(name.toLowerCase());
      const child = makeNode(name, (node.path ? node.path + '/' : '') + name, node, true);
      const set = new Set(fs);
      child.files = fs;
      node.files = node.files.filter((f) => !set.has(f));
      node.folders.push(child);
      autoGroup(child, depth + 1);
    }
  }

  function finalize(node) {
    node.folders.sort((a, b) => a.name.localeCompare(b.name, undefined, { numeric: true, sensitivity: 'base' }));
    for (const f of node.files) {
      f.vpath = (node.path ? node.path + '/' : '') + f.name;
      f.node = node;
      state.byPath.set(f.vpath, f);
      node.count++; node.size += f.s;
      if (f.type === 'image') node.images++; else if (f.type === 'audio') node.audio++;
    }
    for (const c of node.folders) {
      finalize(c);
      node.count += c.count; node.size += c.size; node.images += c.images; node.audio += c.audio;
    }
  }

  function buildTree(files) {
    state.root = makeNode('Home', '', null);
    for (const f of files) {
      const segs = f.p.split('/');
      f.name = segs.pop();
      f.base = f.name.replace(/\.[^.]+$/, '');
      f.ext = (f.name.match(/\.([^.]+)$/) || [, ''])[1].toLowerCase();
      f.type = IMG.test(f.name) ? 'image' : AUD.test(f.name) ? 'audio' : 'other';
      f.lc = f.p.toLowerCase();
      let n = state.root;
      for (const s of segs) {
        let c = n.folders.find((x) => x.name === s);
        if (!c) { c = makeNode(s, (n.path ? n.path + '/' : '') + s, n); n.folders.push(c); }
        n = c;
      }
      n.files.push(f);
      state.all.push(f);
    }
    (function rec(n) { for (const c of [...n.folders]) rec(c); autoGroup(n, 0); })(state.root);
    finalize(state.root);
  }

  const kindOf = (n) => (n.audio && !n.images ? 'audio' : 'image');

  function renderTree() {
    const html = [];
    const rec = (n, depth) => {
      for (const c of n.folders) {
        const open = state.expanded.has(c.path);
        const has = c.folders.length > 0;
        const active = state.cur === c && !state.query;
        html.push(`<div class="tree-row${active ? ' active' : ''}" role="treeitem" aria-expanded="${has ? open : ''}" data-path="${esc(c.path)}">
          <button class="tree-toggle${has ? '' : ' leaf'}${open ? ' open' : ''}" data-toggle="${esc(c.path)}" aria-label="${open ? 'Collapse' : 'Expand'} ${esc(c.name)}" tabindex="${has ? 0 : -1}"><svg><use href="#i-chev"/></svg></button>
          <a class="tree-link" href="#/${enc(c.path)}"><svg class="tree-ico"><use href="#i-folder"/></svg><span class="tree-name">${esc(c.name)}</span><span class="tree-count">${fmtNum(c.count)}</span></a>
        </div>`);
        if (has && open) { html.push('<div class="tree-kids" role="group">'); rec(c, depth + 1); html.push('</div>'); }
      }
    };
    rec(state.root, 0);
    el.tree.innerHTML = html.join('');
    const act = el.tree.querySelector('.tree-row.active');
    if (act) {
      const r = act.getBoundingClientRect(), t = el.tree.getBoundingClientRect();
      if (r.top < t.top || r.bottom > t.bottom) act.scrollIntoView({ block: 'center' });
    }
  }

  el.tree.addEventListener('click', (e) => {
    const t = e.target.closest('[data-toggle]');
    if (t) {
      e.preventDefault();
      const p = t.dataset.toggle;
      state.expanded.has(p) ? state.expanded.delete(p) : state.expanded.add(p);
      save(); renderTree();
      return;
    }
    if (e.target.closest('.tree-link')) {
      if (state.query) clearSearch(false);
      closeSidebar();
    }
  });

  // ---------- listing ----------
  function sortFiles(list) {
    const s = prefs.sort, dir = s.startsWith('-') ? -1 : 1, key = s.replace('-', '');
    const cmpName = (a, b) => a.name.localeCompare(b.name, undefined, { numeric: true, sensitivity: 'base' });
    return list.sort((a, b) => {
      let r = 0;
      if (key === 'size') r = a.s - b.s;
      else if (key === 'res') r = (a.w || 0) * (a.h || 0) - (b.w || 0) * (b.h || 0);
      return (r || cmpName(a, b)) * (key === 'name' ? dir : r ? dir : 1);
    });
  }

  function filesUnder(n) { const out = []; (function rec(x) { out.push(...x.files); x.folders.forEach(rec); })(n); return out; }

  function compute() {
    let list;
    if (state.query) {
      const terms = state.query.toLowerCase().split(/\s+/).filter(Boolean);
      list = state.all.filter((f) => terms.every((t) => f.lc.includes(t) || f.vpath.toLowerCase().includes(t)));
    } else list = state.cur.files.slice();
    if (prefs.type !== 'all') list = list.filter((f) => f.type === prefs.type);
    state.list = sortFiles(list);
  }

  function renderCrumbs() {
    if (state.query) {
      el.crumbs.innerHTML = `<a href="#/">Home</a><svg><use href="#i-chev"/></svg><span class="cur">Results for “${esc(state.query)}”</span><button class="clear-search" type="button">Clear</button>`;
      return;
    }
    const parts = [];
    for (let n = state.cur; n; n = n.parent) parts.unshift(n);
    el.crumbs.innerHTML = parts.map((n, i) => i === parts.length - 1
      ? `<span class="cur">${esc(n.name)}</span>`
      : `<a href="#/${enc(n.path)}">${esc(n.name)}</a><svg><use href="#i-chev"/></svg>`).join('');
    el.crumbs.scrollLeft = el.crumbs.scrollWidth;
  }
  el.crumbs.addEventListener('click', (e) => { if (e.target.closest('.clear-search')) clearSearch(true); });

  function renderFolders() {
    if (state.query) { el.folders.innerHTML = ''; return; }
    let fs = state.cur.folders;
    if (prefs.type !== 'all') fs = fs.filter((c) => (prefs.type === 'image' ? c.images : c.audio));
    el.folders.innerHTML = fs.map((c) => `<a class="folder-card" href="#/${enc(c.path)}">
      <span class="fi ${kindOf(c)}"><svg><use href="#i-folder"/></svg></span>
      <div><div class="fn">${esc(c.name)}</div><div class="fc">${fmtNum(c.count)} file${c.count === 1 ? '' : 's'} · ${fmtSize(c.size)}</div></div></a>`).join('');
  }

  function itemHTML(f, i) {
    const playing = state.audio.file === f;
    const paused = state.audio.el.paused ? ' paused' : '';
    const eq = playing ? `<span class="eq"><i></i><i></i><i></i></span>` : '';
    const sub = [state.query ? esc(f.node.path || 'Home') : '', f.type === 'image' ? dims(f) : f.ext.toUpperCase(), fmtSize(f.s)].filter(Boolean).join(' · ');
    const pixel = f.w && f.w <= 64 ? ' pixel' : '';
    let thumb;
    if (f.type === 'image') thumb = `<div class="thumb"><img loading="lazy" decoding="async" class="${pixel}" src="${thumbUrl(f)}" alt=""></div>`;
    else if (f.type === 'audio') thumb = `<div class="thumb audio"><svg><use href="#i-wave"/></svg></div>`;
    else thumb = `<div class="thumb other"><svg><use href="#i-file"/></svg></div>`;
    const cls = (playing ? ' playing' : '') + paused;
    if (prefs.view === 'grid') {
      return `<button class="card${cls}" data-i="${i}" title="${esc(f.name)}">${thumb}<div class="meta"><div class="name">${eq}${highlight(f.name)}</div><div class="sub">${sub}</div></div></button>`;
    }
    return `<div class="row${cls}" data-i="${i}" role="button" tabindex="0" title="${esc(f.name)}">${thumb}
      <div class="info"><div class="name">${eq}${highlight(f.name)}</div><div class="sub">${sub}</div></div>
      <button class="icon-btn dl" data-dl="${i}" aria-label="Download ${esc(f.name)}"><svg><use href="#i-download"/></svg></button></div>`;
  }

  function renderMore() {
    if (state.rendered >= state.list.length) return;
    const end = Math.min(state.rendered + CHUNK, state.list.length);
    let html = '';
    for (let i = state.rendered; i < end; i++) html += itemHTML(state.list[i], i);
    el.files.insertAdjacentHTML('beforeend', html);
    state.rendered = end;
  }

  function render(resetScroll) {
    compute();
    el.files.className = 'files ' + prefs.view;
    el.files.innerHTML = '';
    state.rendered = 0;
    renderCrumbs(); renderFolders(); renderMore();
    const n = state.list.length;
    const folders = state.query ? 0 : el.folders.children.length;
    const total = state.list.reduce((a, f) => a + f.s, 0);
    el.summary.textContent = [
      folders ? `${folders} folder${folders === 1 ? '' : 's'}` : '',
      `${fmtNum(n)} file${n === 1 ? '' : 's'}`,
      n ? fmtSize(total) : '',
    ].filter(Boolean).join(' · ');
    el.empty.hidden = n || folders ? true : false;
    el.empty.innerHTML = state.query
      ? `<svg style="width:40px;height:40px"><use href="#i-search"/></svg><div>No files match <b>“${esc(state.query)}”</b>${prefs.type !== 'all' ? ' with this filter' : ''}.</div>`
      : `<div>This folder has no ${prefs.type === 'all' ? '' : prefs.type + ' '}files.</div>`;
    if (resetScroll) window.scrollTo(0, 0);
    document.title = (state.query ? `“${state.query}”` : state.cur.path ? state.cur.name : 'Hitman Sniper Asset Library') + (state.query || state.cur.path ? ' · Hitman Sniper Assets' : '');
    renderTree();
  }

  new IntersectionObserver((es) => { if (es[0].isIntersecting) renderMore(); }, { rootMargin: '1200px 0px' }).observe(el.sentinel);

  el.files.addEventListener('load', (e) => { if (e.target.tagName === 'IMG') e.target.classList.add('ok'); }, true);
  el.files.addEventListener('error', (e) => {
    const img = e.target;
    if (img.tagName !== 'IMG') return;
    const f = state.list[+img.closest('[data-i]').dataset.i];
    if (f && !img.dataset.fb) { img.dataset.fb = 1; img.src = url(f, true); } // thumbnail/CDN failed: try raw
  }, true);

  el.files.addEventListener('click', (e) => {
    const dl = e.target.closest('[data-dl]');
    if (dl) { e.stopPropagation(); download(state.list[+dl.dataset.dl]); return; }
    const item = e.target.closest('[data-i]');
    if (item) activate(+item.dataset.i);
  });
  el.files.addEventListener('keydown', (e) => {
    if ((e.key === 'Enter' || e.key === ' ') && e.target.matches('.row')) { e.preventDefault(); activate(+e.target.dataset.i); }
  });

  function activate(i) {
    const f = state.list[i];
    if (!f) return;
    if (f.type === 'image') openViewer(state.list.filter((x) => x.type === 'image'), f, true);
    else if (f.type === 'audio') {
      if (state.audio.file === f) togglePlay();
      else playAudio(state.list.filter((x) => x.type === 'audio'), f);
    } else window.open(url(f), '_blank', 'noopener');
  }

  function refreshPlayingMarks() {
    el.files.querySelectorAll('[data-i]').forEach((node) => {
      const f = state.list[+node.dataset.i];
      if (f.type !== 'audio') return;
      const was = node.classList.contains('playing'), is = state.audio.file === f;
      if (was || is) {
        const tmp = document.createElement('div');
        tmp.innerHTML = itemHTML(f, +node.dataset.i);
        node.replaceWith(tmp.firstElementChild);
      }
    });
  }

  // ---------- search ----------
  let searchT;
  el.search.addEventListener('input', () => {
    clearTimeout(searchT);
    el.searchClear.hidden = !el.search.value;
    searchT = setTimeout(() => { state.query = el.search.value.trim(); render(true); }, 120);
  });
  el.search.addEventListener('keydown', (e) => {
    if (e.key === 'Escape') { clearSearch(true); el.search.blur(); }
    if (e.key === 'Enter') el.search.blur(); // hides phone keyboard
  });
  el.searchClear.addEventListener('click', () => { clearSearch(true); el.search.focus(); });
  function clearSearch(rerender) {
    el.search.value = ''; el.searchClear.hidden = true;
    if (!state.query) return;
    state.query = '';
    if (rerender) render(true);
  }

  // ---------- controls ----------
  function syncControls() {
    el.typeFilter.querySelectorAll('button').forEach((b) => b.setAttribute('aria-checked', b.dataset.type === prefs.type));
    el.viewToggle.querySelectorAll('button').forEach((b) => b.setAttribute('aria-checked', b.dataset.view === prefs.view));
    el.sort.value = prefs.sort;
  }
  el.typeFilter.addEventListener('click', (e) => { const b = e.target.closest('button'); if (!b) return; prefs.type = b.dataset.type; save(); syncControls(); render(); });
  el.viewToggle.addEventListener('click', (e) => { const b = e.target.closest('button'); if (!b) return; prefs.view = b.dataset.view; save(); syncControls(); render(); });
  el.sort.addEventListener('change', () => { prefs.sort = el.sort.value; save(); render(); });

  // ---------- sidebar (mobile drawer) ----------
  function openSidebar() { el.sidebar.classList.add('open'); el.scrim.hidden = false; el.menuBtn.setAttribute('aria-expanded', 'true'); document.body.classList.add('lock'); }
  function closeSidebar() { el.sidebar.classList.remove('open'); el.scrim.hidden = true; el.menuBtn.setAttribute('aria-expanded', 'false'); if (el.viewer.hidden) document.body.classList.remove('lock'); }
  el.menuBtn.addEventListener('click', openSidebar);
  $('#sidebarClose').addEventListener('click', closeSidebar);
  el.scrim.addEventListener('click', closeSidebar);
  let sx = null;
  el.sidebar.addEventListener('touchstart', (e) => { sx = e.touches[0].clientX; }, { passive: true });
  el.sidebar.addEventListener('touchend', (e) => { if (sx != null && sx - e.changedTouches[0].clientX > 70) closeSidebar(); sx = null; });

  // ---------- downloads ----------
  async function download(f) {
    toast('Downloading ' + f.name + '…');
    for (const raw of [false, true]) {
      try {
        const r = await fetch(url(f, raw));
        if (!r.ok) throw new Error(r.status);
        const blob = await r.blob();
        const a = document.createElement('a');
        a.href = URL.createObjectURL(blob); a.download = f.name;
        document.body.appendChild(a); a.click(); a.remove();
        setTimeout(() => URL.revokeObjectURL(a.href), 30000);
        return;
      } catch {}
    }
    window.open(url(f, true), '_blank', 'noopener');
  }
  async function copyLink(f) {
    const u = url(f);
    try { await navigator.clipboard.writeText(u); toast('Link copied'); }
    catch { prompt('Copy link:', u); }
  }

  // ---------- image viewer ----------
  const BGS = ['bg-checker', 'bg-dark', 'bg-light'];
  function openViewer(list, f, push) {
    const v = state.viewer;
    v.list = list; v.idx = list.indexOf(f);
    if (el.viewer.hidden) { el.viewer.hidden = false; document.body.classList.add('lock'); }
    showImage();
    if (push) { v.pushed = true; location.hash = '#/' + enc(f.vpath); }
  }
  function showImage() {
    const v = state.viewer, f = v.list[v.idx];
    if (!f) return;
    setZoom(false);
    el.vImg.classList.remove('ok'); el.vSpin.hidden = false;
    el.vImg.classList.toggle('pixel', !!(f.w && f.w <= 128));
    el.vThumb.src = f.t ? thumbUrl(f) : '';
    el.vThumb.hidden = !f.t;
    el.vThumb.style.width = f.w ? f.w + 'px' : ''; // placeholder takes the real image's size
    el.vImg.dataset.fb = '';
    el.vImg.src = url(f);
    el.vImg.alt = f.name;
    el.vName.textContent = f.name;
    el.vMeta.textContent = [dims(f), fmtSize(f.s), f.node.path].filter(Boolean).join(' · ');
    el.vOpen.href = url(f);
    el.vCount.textContent = `${v.idx + 1} / ${v.list.length}`;
    $('#vPrev').hidden = $('#vNext').hidden = v.list.length < 2;
    for (const d of [-1, 1]) { const n = v.list[v.idx + d]; if (n) new Image().src = n.s < 3e6 ? url(n) : thumbUrl(n); } // preload neighbours
  }
  el.vImg.addEventListener('load', () => { el.vImg.classList.add('ok'); el.vSpin.hidden = true; el.vThumb.hidden = true; });
  el.vImg.addEventListener('error', () => {
    const f = state.viewer.list[state.viewer.idx];
    if (f && !el.vImg.dataset.fb) { el.vImg.dataset.fb = 1; el.vImg.src = url(f, true); }
    else { el.vSpin.hidden = true; toast('Could not load image'); }
  });
  function step(d) {
    const v = state.viewer, n = v.idx + d;
    if (n < 0 || n >= v.list.length) return;
    v.idx = n; showImage();
    history.replaceState(history.state, '', '#/' + enc(v.list[n].vpath));
  }
  function closeViewer(fromHash) {
    if (el.viewer.hidden) return;
    el.viewer.hidden = true; el.vImg.removeAttribute('src');
    if (el.sidebar.classList.contains('open') === false) document.body.classList.remove('lock');
    if (!fromHash) {
      if (state.viewer.pushed) history.back();
      else history.replaceState(history.state, '', '#/' + enc(state.cur.path));
    }
    state.viewer.pushed = false;
  }
  function setZoom(z) {
    const v = state.viewer; v.zoom = z;
    el.vStage.classList.toggle('zoomed', z);
    if (z) requestAnimationFrame(() => { // centre the image
      el.vStage.scrollLeft = (el.vStage.scrollWidth - el.vStage.clientWidth) / 2;
      el.vStage.scrollTop = (el.vStage.scrollHeight - el.vStage.clientHeight) / 2;
    });
  }
  $('#vClose').addEventListener('click', () => closeViewer(false));
  $('#vPrev').addEventListener('click', () => step(-1));
  $('#vNext').addEventListener('click', () => step(1));
  $('#vZoom').addEventListener('click', () => setZoom(!state.viewer.zoom));
  $('#vBg').addEventListener('click', () => {
    el.vStage.classList.remove(BGS[state.viewer.bg]);
    state.viewer.bg = (state.viewer.bg + 1) % BGS.length;
    el.vStage.classList.add(BGS[state.viewer.bg]);
  });
  $('#vCopy').addEventListener('click', () => copyLink(state.viewer.list[state.viewer.idx]));
  $('#vDownload').addEventListener('click', () => download(state.viewer.list[state.viewer.idx]));
  let lastTap = 0, touch = null;
  el.vStage.addEventListener('click', (e) => {
    if (e.pointerType === 'touch' || matchMedia('(hover: none)').matches) {
      const now = Date.now();
      if (now - lastTap < 300) setZoom(!state.viewer.zoom);
      lastTap = now;
    } else if (e.target === el.vImg || state.viewer.zoom) setZoom(!state.viewer.zoom);
  });
  el.vStage.addEventListener('touchstart', (e) => {
    touch = e.touches.length === 1 ? { x: e.touches[0].clientX, y: e.touches[0].clientY, t: Date.now() } : null;
  }, { passive: true });
  el.vStage.addEventListener('touchend', (e) => {
    if (!touch || state.viewer.zoom) return;
    const dx = e.changedTouches[0].clientX - touch.x, dy = e.changedTouches[0].clientY - touch.y;
    if (Date.now() - touch.t < 600) {
      if (Math.abs(dx) > 50 && Math.abs(dx) > Math.abs(dy) * 1.3) step(dx < 0 ? 1 : -1);
      else if (dy > 90 && Math.abs(dy) > Math.abs(dx) * 1.5) closeViewer(false);
    }
    touch = null;
  });

  // ---------- audio player ----------
  const au = state.audio.el;
  au.preload = 'metadata';
  au.volume = prefs.vol;
  el.pVol.value = prefs.vol; setRange(el.pVol);
  function playAudio(list, f) {
    const A = state.audio;
    A.list = list; A.idx = list.indexOf(f); A.file = f;
    au.dataset.fb = '';
    resetBar();
    au.src = url(f);
    au.play().catch(() => {});
    el.player.hidden = false; document.body.classList.add('has-player');
    el.pName.textContent = f.name;
    el.pName.title = f.name;
    if ('mediaSession' in navigator) {
      navigator.mediaSession.metadata = new MediaMetadata({ title: f.base, artist: 'Hitman Sniper', album: f.node.path, artwork: [{ src: 'favicon.svg', sizes: 'any', type: 'image/svg+xml' }] });
    }
    refreshPlayingMarks();
  }
  function resetBar() { el.seek.value = 0; setRange(el.seek); el.pTime.textContent = '0:00 / 0:00'; }
  function togglePlay() { if (!state.audio.file) return; au.paused ? au.play().catch(() => {}) : au.pause(); }
  function audioStep(d) {
    const A = state.audio, n = A.list[A.idx + d];
    if (n) playAudio(A.list, n);
  }
  function syncPlayBtn() {
    el.pPlay.innerHTML = `<svg><use href="#i-${au.paused ? 'play' : 'pause'}"/></svg>`;
    el.pPlay.setAttribute('aria-label', au.paused ? 'Play' : 'Pause');
    refreshPlayingMarks();
  }
  au.addEventListener('play', syncPlayBtn);
  au.addEventListener('pause', syncPlayBtn);
  au.addEventListener('ended', () => { au.currentTime = 0; el.seek.value = 0; setRange(el.seek); });
  au.addEventListener('error', () => {
    const f = state.audio.file;
    if (f && !au.dataset.fb) { au.dataset.fb = 1; au.src = url(f, true); au.play().catch(() => {}); }
    else if (f) toast(/\.ogg$/i.test(f.name) ? 'This browser cannot play OGG audio' : 'Could not play audio');
  });
  let seeking = false;
  au.addEventListener('timeupdate', () => {
    if (!seeking && au.duration) { el.seek.value = (au.currentTime / au.duration) * 1000; setRange(el.seek); }
    el.pTime.textContent = `${fmtTime(au.currentTime)} / ${fmtTime(au.duration)}`;
  });
  au.addEventListener('loadedmetadata', () => { el.pTime.textContent = `0:00 / ${fmtTime(au.duration)}`; });
  el.seek.addEventListener('input', () => { seeking = true; setRange(el.seek); if (au.duration) el.pTime.textContent = `${fmtTime((el.seek.value / 1000) * au.duration)} / ${fmtTime(au.duration)}`; });
  el.seek.addEventListener('change', () => { if (au.duration) au.currentTime = (el.seek.value / 1000) * au.duration; seeking = false; });
  el.pVol.addEventListener('input', () => { au.volume = +el.pVol.value; prefs.vol = au.volume; setRange(el.pVol); save(); });
  el.pPlay.addEventListener('click', togglePlay);
  $('#pPrev').addEventListener('click', () => audioStep(-1));
  $('#pNext').addEventListener('click', () => audioStep(1));
  $('#pDownload').addEventListener('click', () => state.audio.file && download(state.audio.file));
  $('#pClose').addEventListener('click', () => {
    au.pause(); au.removeAttribute('src'); state.audio.file = null;
    el.player.hidden = true; document.body.classList.remove('has-player');
    refreshPlayingMarks();
  });
  if ('mediaSession' in navigator) {
    navigator.mediaSession.setActionHandler('previoustrack', () => audioStep(-1));
    navigator.mediaSession.setActionHandler('nexttrack', () => audioStep(1));
  }

  // ---------- keyboard ----------
  document.addEventListener('keydown', (e) => {
    const typing = e.target.matches('input, select, textarea');
    if (!el.viewer.hidden) {
      if (e.key === 'Escape') closeViewer(false);
      else if (e.key === 'ArrowLeft') step(-1);
      else if (e.key === 'ArrowRight') step(1);
      else if (e.key === 'z' || e.key === 'Z') setZoom(!state.viewer.zoom);
      else if (e.key === 'b' || e.key === 'B') $('#vBg').click();
      else if (e.key === 'd' || e.key === 'D') $('#vDownload').click();
      return;
    }
    if (typing) return;
    if (e.key === '/' || (e.key === 'k' && (e.ctrlKey || e.metaKey))) { e.preventDefault(); el.search.focus(); el.search.select(); }
    else if (e.key === 'Escape') closeSidebar();
    else if (e.key === ' ' && state.audio.file && !e.target.closest('button, [role=button]')) { e.preventDefault(); togglePlay(); }
    else if (e.key === 'Backspace' && state.cur && state.cur.parent) location.hash = '#/' + enc(state.cur.parent.path);
  });

  // ---------- routing ----------
  function route() {
    const path = dec(location.hash.replace(/^#\/?/, '').replace(/\/$/, ''));
    const file = state.byPath.get(path);
    if (file) {
      // keep the current listing (e.g. search results) if it already shows this file
      if (!state.list.includes(file) && state.cur !== file.node) { clearSearch(false); go(file.node); }
      const pool = state.list.includes(file) ? state.list : file.node.files;
      if (file.type === 'image') openViewer(pool.filter((x) => x.type === 'image'), file, false);
      else if (file.type === 'audio') { closeViewer(true); if (state.audio.file !== file) playAudio(pool.filter((x) => x.type === 'audio'), file); }
      return;
    }
    closeViewer(true);
    const node = state.nodes.get(path) || state.root;
    if (node !== state.cur) { if (state.query) clearSearch(false); go(node); }
  }
  function go(node) {
    state.cur = node;
    for (let n = node.parent; n && n.path; n = n.parent) state.expanded.add(n.path); // reveal in tree
    if (node.folders.length) state.expanded.add(node.path);
    save();
    render(false);
    restoreScroll();
  }

  // ---------- scroll memory ----------
  // Each history entry gets an id. Going back to an entry restores where you
  // were; opening a folder fresh (new entry) starts at the top.
  if ('scrollRestoration' in history) history.scrollRestoration = 'manual';
  const scrollMem = (() => { try { return JSON.parse(sessionStorage.getItem('hsa:scroll')) || {}; } catch { return {}; } })();
  let restoring = false, scrollRaf = 0, persistT;
  function entryId() {
    let st = history.state;
    if (!st || !st.id) {
      st = Object.assign({}, st, { id: Date.now().toString(36) + Math.random().toString(36).slice(2, 7) });
      history.replaceState(st, '');
    }
    return st.id;
  }
  function restoreScroll() {
    const y = scrollMem[entryId()] || 0;
    restoring = true;
    while (document.documentElement.scrollHeight < y + innerHeight && state.rendered < state.list.length) renderMore();
    window.scrollTo(0, y);
    requestAnimationFrame(() => { restoring = false; });
  }
  window.addEventListener('scroll', () => {
    if (scrollRaf || restoring || !el.viewer.hidden) return;
    scrollRaf = requestAnimationFrame(() => {
      scrollRaf = 0;
      const id = history.state && history.state.id;
      if (!id) return;
      delete scrollMem[id]; scrollMem[id] = Math.round(window.scrollY); // keep newest last
      clearTimeout(persistT);
      persistT = setTimeout(() => {
        const keys = Object.keys(scrollMem);
        for (const k of keys.slice(0, Math.max(0, keys.length - 150))) delete scrollMem[k];
        try { sessionStorage.setItem('hsa:scroll', JSON.stringify(scrollMem)); } catch {}
      }, 250);
    });
  }, { passive: true });
  window.addEventListener('hashchange', route);

  // ---------- boot ----------
  syncControls();
  fetch('manifest.json', { cache: 'no-cache' })
    .then((r) => { if (!r.ok) throw new Error('HTTP ' + r.status); return r.json(); })
    .then((m) => {
      state.manifest = m;
      buildTree(m.files);
      const r = state.root;
      el.search.placeholder = `Search ${fmtNum(r.count)} files…`;
      el.stats.innerHTML = `${fmtNum(r.images)} images · ${fmtNum(r.audio)} audio · ${fmtSize(r.size)}` +
        (m.repo ? `<br><a href="https://github.com/${esc(m.repo)}" target="_blank" rel="noopener">View on GitHub</a>` : '') +
        (m.generated ? ` · updated ${new Date(m.generated).toLocaleDateString()}` : '');
      el.loading.hidden = true;
      state.expanded.add('images'); state.expanded.add('audio');
      route();
    })
    .catch((err) => {
      el.loading.innerHTML = `<div><b>Could not load the file list.</b><br>${esc(err.message)}</div>`;
    });
})();
