<script setup lang="ts">
import { AlertCircle, BookOpen, Calendar, UserPlus } from 'lucide-vue-next'
import { Card, CardContent, CardHeader, CardTitle } from './ui/card'
import CardDescription from './ui/card/CardDescription.vue'
import Button from './ui/button/Button.vue'
import { Separator } from './ui/separator'
</script>
<template>
  <Card>
    <CardHeader>
      <CardTitle>Quick Actions</CardTitle>
      <CardDescription>Common Library Operations</CardDescription>
    </CardHeader>
    <Separator />
    <CardContent class="flex flex-col gap-2">
      <Button class="w-full cursor-pointer justify-start">
        <BookOpen class="w-4 h-4 mr-2" />
        Add New Books
      </Button>
      <Button class="w-full cursor-pointer justify-start">
        <UserPlus class="w-4 h-4 mr-2" />
        Register Member
      </Button>
      <Button class="w-full cursor-pointer justify-start">
        <Calendar class="w-4 h-4 mr-2" />
        Proccess Return
      </Button>
      <Button class="w-full cursor-pointer justify-start">
        <AlertCircle class="w-4 h-4 mr-2" />
        View Overdue
      </Button>
    </CardContent>
  </Card>
</template>
