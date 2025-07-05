import { SeedPostgres } from '@snaplet/seed/adapter-postgres'
import { defineConfig } from '@snaplet/seed/config'
import postgres from 'postgres'

export default defineConfig({
  adapter: () => {
    const client = postgres('postgres://postgres@localhost:5432/library')
    return new SeedPostgres(client)
  },
})
