<script setup lang="ts">
import { Card, CardHeader, CardContent, CardTitle } from '@/components/ui/card'

import { BookOpen, Building2, Calendar, Users } from 'lucide-vue-next'

const stats = [
  {
    title: 'Total Books',
    value: '12,847',
    change: '+2.5%',
    icon: BookOpen,
    color: 'text-blue-600',
  },
  {
    title: 'Authors',
    value: '3,421',
    change: '+1.2%',
    icon: Users,
    color: 'text-green-600',
  },
  {
    title: 'Publishers',
    value: '856',
    change: '+0.8%',
    icon: Building2,
    color: 'text-purple-600',
  },
  {
    title: 'Active Loans',
    value: '1,234',
    change: '-3.1%',
    icon: Calendar,
    color: 'text-orange-600',
  },
]
</script>
<template>
  <div class="grid auto-rows-min gap-4 md:grid-cols-2 lg:grid-cols-4">
    <Card v-for="stat in stats" :key="stat.title">
      <CardHeader class="flex flex-row items-center justify-between space-y-0 pb-2">
        <CardTitle class="text-sm font-medium">{{ stat.title }}</CardTitle>
        <component :is="stat.icon" :class="stat.color" />
      </CardHeader>
      <CardContent>
        <div class="text-2xl font-bold">{{ stat.value }}</div>
        <p class="text-xs text-muted-foreground">
          <span
            :class="{
              'text-green-600': stat.change.startsWith('+'),
              'text-red-600': stat.change.startsWith('-'),
            }"
          >
            {{ stat.change }}
          </span>
          from last month
        </p>
      </CardContent>
    </Card>
  </div>
</template>
