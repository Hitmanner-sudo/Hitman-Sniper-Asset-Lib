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
        
