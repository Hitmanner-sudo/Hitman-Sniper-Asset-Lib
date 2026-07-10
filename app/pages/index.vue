<template>
  <div style="font-family:sans-serif;padding:2rem;background:#111;color:#eee;min-height:100vh">
    <h1>Hitman Sniper Asset Library</h1>

    <h2>Images ({{ data?.images.length ?? 0 }})</h2>
    <div style="display:flex;flex-wrap:wrap;gap:8px">
      <div v-for="f in data?.images" :key="f" style="text-align:center">
        <img :src="`/Hitman-Sniper-Asset-Lib/images/${f}`"
             style="max-width:150px;max-height:150px;object-fit:contain;background:#222;padding:4px" />
        <div style="font-size:10px;max-width:150px;word-break:break-all">{{ f }}</div>
      </div>
    </div>

    <h2>Audio ({{ data?.audio.length ?? 0 }})</h2>
    <div v-for="f in data?.audio" :key="f" style="margin-bottom:1rem">
      <div>{{ f }}</div>
      <audio :src="`/Hitman-Sniper-Asset-Lib/audio/${f}`" controls />
    </div>
  </div>
</template>

<script setup>
const { data } = await useFetch('/api/files')
</script>
