<script setup lang="ts">
import { Card, CardContent, CardDescription, CardHeader } from '@/components/ui/card'
import CardTitle from './ui/card/CardTitle.vue'
import { Badge } from './ui/badge'
import { getVariantsForBookStatus } from '@/ultils/ultils'
import { Separator } from './ui/separator'

const recentBooks = [
  {
    title: 'The Great Gatsby',
    author: 'F. Scott Fitzgerald',
    publisher: 'Scribner',
    isbn: '978-0-7432-7356-5',
    status: 'Available',
    copies: 5,
  },
  {
    title: 'To Kill a Mockingbird',
    author: 'Harper Lee',
    publisher: 'J.B. Lippincott & Co.',
    isbn: '978-0-06-112008-4',
    status: 'Borrowed',
    copies: 3,
  },
  {
    title: '1984',
    author: 'George Orwell',
    publisher: 'Secker & Warburg',
    isbn: '978-0-452-28423-4',
    status: 'Available',
    copies: 7,
  },
  {
    title: 'Pride and Prejudice',
    author: 'Jane Austen',
    publisher: 'T. Egerton',
    isbn: '978-0-14-143951-8',
    status: 'Reserved',
    copies: 4,
  },
]
</script>

<template>
  <Card>
    <CardHeader>
      <CardTitle>Recent Books</CardTitle>
      <CardDescription>Latest additions to the library collection</CardDescription>
    </CardHeader>
    <Separator />
    <CardContent>
      <div class="space-y-4">
        <div
          v-for="book in recentBooks"
          :key="book.isbn"
          class="flex items-center justify-between space-x-4"
        >
          <div class="flex-1 space-y-1">
            <p class="text-sm font-medium leading-none">{{ book.title }}</p>
            <p class="text-sm text-muted-foreground">by {{ book.author }} • {{ book.publisher }}</p>
            <p class="text-xs text-muted-foreground">ISBN: {{ book.isbn }}</p>
          </div>
          <div class="flex items-center space-x-2">
            <Badge :variant="getVariantsForBookStatus(book.status)">{{ book.status }}</Badge>
            <span class="text-sm text-muted-foreground">{{ book.copies }} copies</span>
          </div>
        </div>
      </div>
    </CardContent>
  </Card>
</template>
