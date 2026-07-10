import { readdirSync } from 'fs'
import { join } from 'path'

export default defineEventHandler(() => {
  const pub = join(process.cwd(), 'public')
  const images = readdirSync(join(pub, 'images'))
    .filter(f => /\.(png|jpg|jpeg|gif|svg|webp)$/i.test(f))
  const audio = readdirSync(join(pub, 'audio'))
    .filter(f => /\.(ogg|mp3|wav)$/i.test(f))
  return { images, audio }
})
