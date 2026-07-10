import { readdirSync } from 'fs'
import { join } from 'path'

export default defineEventHandler(() => {
  const base = join(process.cwd(), 'public')
  const folders = ['audio', 'images']
  return folders.reduce((acc, folder) => {
    acc[folder] = readdirSync(join(base, folder))
    return acc
  }, {} as Record<string, string[]>)
})
