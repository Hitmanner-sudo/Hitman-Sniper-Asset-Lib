const fs = require('fs')
const path = require('path')

const SOURCE = './ExportedProject/Assets'
const IMAGE_EXTS = ['.png', '.jpg', '.jpeg', '.gif', '.svg']
const AUDIO_EXTS = ['.ogg', '.mp3', '.wav']
const VIDEO_EXTS = ['.mp4']

const images = [], audio = [], video = []

function scan(dir) {
  if (!fs.existsSync(dir)) return
  for (const entry of fs.readdirSync(dir, { withFileTypes: true })) {
    const full = path.join(dir, entry.name)
    if (entry.isDirectory()) { scan(full); continue }
    const ext = path.extname(entry.name).toLowerCase()
    if (ext === '.meta') continue // skip Unity meta files
    const dest = entry.name.replace(/ /g, '_') // spaces → underscores
    if (IMAGE_EXTS.includes(ext)) {
      fs.mkdirSync('./public/images', { recursive: true })
      fs.copyFileSync(full, `./public/images/${dest}`)
      images.push(`/Hitman-Sniper-Asset-Lib/images/${dest}`)
    } else if (AUDIO_EXTS.includes(ext)) {
      fs.mkdirSync('./public/audio', { recursive: true })
      fs.copyFileSync(full, `./public/audio/${dest}`)
      audio.push(`/Hitman-Sniper-Asset-Lib/audio/${dest}`)
    } else if (VIDEO_EXTS.includes(ext)) {
      fs.mkdirSync('./public/video', { recursive: true })
      fs.copyFileSync(full, `./public/video/${dest}`)
      video.push(`/Hitman-Sniper-Asset-Lib/video/${dest}`)
    }
  }
}

scan(SOURCE)
scan('./AuxiliaryFiles')

const vue = `<template>
  <div style="font-family:sans-serif;padding:2rem;background:#111;color:#eee;min-height:100vh">
    <h1>Hitman Sniper Asset Library</h1>

    <h2>Images ({{ images.length }})</h2>
    <div style="display:flex;flex-wrap:wrap;gap:8px">
      <div v-for="f in images" :key="f" style="text-align:center">
        <img :src="f" style="max-width:150px;max-height:150px;object-fit:contain;background:#222;padding:4px" />
        <div style="font-size:10px;max-width:150px;word-break:break-all">{{ f.split('/').pop() }}</div>
      </div>
    </div>

    <h2>Audio ({{ audio.length }})</h2>
    <div v-for="f in audio" :key="f" style="margin-bottom:1rem">
      <div>{{ f.split('/').pop() }}</div>
      <audio :src="f" controls />
    </div>

    <h2>Video ({{ video.length }})</h2>
    <div v-for="f in video" :key="f" style="margin-bottom:1rem">
      <div>{{ f.split('/').pop() }}</div>
      <video :src="f" controls style="max-width:640px;width:100%" />
    </div>
  </div>
</template>

<script setup>
const images = ${JSON.stringify(images, null, 2)}
const audio = ${JSON.stringify(audio, null, 2)}
const video = ${JSON.stringify(video, null, 2)}
</script>`

fs.writeFileSync('./app/pages/index.vue', vue)
console.log(`Done! Images: ${images.length}, Audio: ${audio.length}, Video: ${video.length}`)
