<script setup>
const { data } = await useFetch('/api/files')
</script>

<template>
  <div style="font-family: sans-serif; padding: 2rem">
    <h1>Asset Library</h1>
    <div v-for="(files, folder) in data" :key="folder">
      <h2>{{ folder }}</h2>
      <ul>
        <li v-for="file in files" :key="file">
          <a :href="`/${folder}/${file}`" target="_blank">{{ file }}</a>
        </li>
      </ul>
    </div>
  </div>
</template>
