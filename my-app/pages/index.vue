<script setup>
import { ref, onMounted } from 'vue'

const assetLibrary = ref({ audio: [], images: [] })
const loading = ref(true)

onMounted(async () => {
  try {
    const res = await fetch('./manifest.json')
    assetLibrary.value = await res.json()
  } catch (err) {
    console.error(err)
  } finally {
    loading.value = false
  }
})
</script>

<template>
  <div style="font-family: monospace; padding: 2.5rem; background-color: #0b0f19; color: #cbd5e1; min-height: 100vh;">
    <header style="border-bottom: 2px solid #1e293b; padding-bottom: 1rem; margin-bottom: 2.5rem;">
      <h1 style="color: #38bdf8; font-size: 1.75rem; margin: 0; letter-spacing: -0.025em;">
        🎯 HITMAN SNIPER ASSET EXPLORER
      </h1>
      <p style="color: #64748b; margin: 0.5rem 0 0 0; font-size: 0.875rem;">
        Static GitHub Pages Distribution Center
      </p>
    </header>

    <main>
      <div v-if="loading" style="color: #38bdf8;">Cataloging extracted sniper textures...</div>

      <div v-else v-for="(files, folder) in assetLibrary" :key="folder" style="margin-bottom: 3rem; background: #111827; border: 1px solid #1e293b; border-radius: 6px; padding: 1.5rem;">
        <h2 style="color: #f1f5f9; font-size: 1.1rem; margin-top: 0; border-bottom: 1px solid #1e293b; padding-bottom: 0.5rem;">
          📁 /public/{{ folder }}/ ({{ files.length }} assets indexed)
        </h2>
        
        <ul style="list-style: none; padding: 0; margin: 1rem 0 0 0; max-height: 450px; overflow-y: auto;">
          <li v-for="file in files" :key="file" style="padding: 0.4rem 0.75rem; display: flex; align-items: center; gap: 0.75rem;">
            <span>📄</span>
            <a :href="`./${folder}/${file}`" target="_blank" style="color: #34d399; text-decoration: none; word-break: break-all;">
              {{ file }}
            </a>
          </li>
        </ul>
      </div>
    </main>
  </div>
</template>
