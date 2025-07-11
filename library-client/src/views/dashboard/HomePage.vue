<script setup lang="ts">
import PopularAuthors from '@/components/PopularAuthors.vue'
import PopularPublishers from '@/components/PopularPublishers.vue'
import QuickActions from '@/components/QuickActions.vue'
import RecentsBook from '@/components/RecentsBook.vue'
import StatComponent from '@/components/StatComponent.vue'
</script>

<template>
  <div class="flex flex-1 flex-col gap-4 p-4">
    <StatComponent />
    <div class="grid gap-4 md:grid-cols-2 lg:grid-cols-3">
      <RecentsBook class="md:col-span-2" />
      <QuickActions />
    </div>
    <div className="grid gap-4 md:grid-cols-2">
      <PopularAuthors />
      <PopularPublishers />
    </div>
  </div>
</template>
