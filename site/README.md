# Asset browser

A static file browser for everything in `public/`, live at
**https://hitmanner-sudo.github.io/Hitman-Sniper-Asset-Lib/**.

It is deployed to GitHub Pages by `.github/workflows/deploy.yml` on every push to `main`.

- Folders like `images/NPC` or `audio/sfx/Weapon` are created automatically from filename prefixes.
- Thumbnails are generated at build time, so phones only download small previews.
- Full files stream from jsDelivr, with raw.githubusercontent.com as the fallback and for files over 20 MB.
  `public/` is over 1 GB, which is above the GitHub Pages size limit, so the files are not copied into the site.

## Pages setting

Repository **Settings → Pages → Build and deployment → Source** must be **GitHub Actions** (already set).

## Run locally

```sh
cd site
npm install
node build.mjs          # writes ../_site (add --no-thumbs to skip thumbnails)
cd ..
python3 -m http.server 8000
# open http://localhost:8000/_site/
```

## Shortcuts

`/` search · `←` `→` previous/next image · `Z` actual size · `B` background · `D` download · `Esc` close · `Space` play/pause audio
