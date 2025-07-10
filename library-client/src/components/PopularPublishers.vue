<script setup lang="ts">
import { Card, CardContent, CardDescription, CardHeader, CardTitle } from './ui/card'
import { Separator } from './ui/separator'

const topPublishers = [
  { id: 1, name: 'Penguin Random House', books: 1247, active: 89 },
  { id: 2, name: 'HarperCollins', books: 892, active: 67 },
  { id: 3, name: 'Macmillan Publishers', books: 634, active: 45 },
  { id: 4, name: 'Simon & Schuster', books: 567, active: 38 },
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
          v-for="publisher in topPublishers"
          :key="publisher.id"
          class="flex items-center justify-between"
        >
          <div class="flex-1">
            <div class="text-sm font-medium">{{ publisher.name }}</div>
            <div class="text-xs text-muted-foreground">{{ publisher.books }} books total</div>
          </div>
          <div class="text-right">
            <p class="text-sm font-medium">{{ publisher.active }}</p>
            <p class="text-xs text-muted-foreground">active loans</p>
          </div>
        </div>
      </div>
    </CardContent>
  </Card>
</template>
