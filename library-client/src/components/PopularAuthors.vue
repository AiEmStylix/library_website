<script setup lang="ts">
import { TrendingUp } from 'lucide-vue-next'
import { Card, CardDescription, CardHeader } from './ui/card'
import CardContent from './ui/card/CardContent.vue'
import CardTitle from './ui/card/CardTitle.vue'
import { Separator } from './ui/separator'

const popularAuthors = [
  { id: 1, name: 'Stephen King', books: 47, borrowed: 156 },
  { id: 2, name: 'Agatha Christie', books: 32, borrowed: 134 },
  { id: 3, name: 'J.K. Rowling', books: 12, borrowed: 289 },
  { id: 4, name: 'George R.R. Martin', books: 8, borrowed: 98 },
]
</script>
<template>
  <Card>
    <CardHeader>
      <CardTitle>Popular Authors</CardTitle>
      <CardDescription>Most borrowed authors this month</CardDescription>
      <Separator />
    </CardHeader>
    <CardContent>
      <div class="space-y-4">
        <div
          v-for="author in popularAuthors"
          :key="author.id"
          class="flex items-center justify-between"
        >
          <div class="flex-1">
            <p class="text-sm font-medium">{{ author.name }}</p>
            <p class="text-xs text-muted-foreground">{{ author.books }} books in collections</p>
          </div>
          <div class="flex items-center gap-2">
            <TrendingUp class="h-4 w-4 text-green-600" />
            <span class="text-sm font-medium">{{ author.borrowed }}</span>
            <span class="text-xs text-muted-foreground"> borrowed</span>
          </div>
        </div>
      </div>
    </CardContent>
  </Card>
</template>
