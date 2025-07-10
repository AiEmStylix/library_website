<script setup lang="ts">
import AppSidebar from '@/components/AppSidebar.vue'
import PopularAuthors from '@/components/PopularAuthors.vue'
import PopularPublishers from '@/components/PopularPublishers.vue'
import QuickActions from '@/components/QuickActions.vue'
import RecentsBook from '@/components/RecentsBook.vue'
import StatComponent from '@/components/StatComponent.vue'
import {
  Breadcrumb,
  BreadcrumbItem,
  BreadcrumbLink,
  BreadcrumbList,
  BreadcrumbPage,
  BreadcrumbSeparator,
} from '@/components/ui/breadcrumb'

import { Separator } from '@/components/ui/separator'
import { SidebarInset, SidebarProvider, SidebarTrigger } from '@/components/ui/sidebar'
</script>

<template>
  <SidebarProvider>
    <AppSidebar />
    <SidebarInset>
      <header class="flex h-16 shrink-0 items-center gap-2 border-b px-4">
        <SidebarTrigger class="-ml-1" />
        <Separator orientation="vertical" class="mr-2 h-4" />
        <Breadcrumb>
          <BreadcrumbList>
            <BreadcrumbItem class="hidden md:block">
              <BreadcrumbLink href="#"> Building Your Application </BreadcrumbLink>
            </BreadcrumbItem>
            <BreadcrumbSeparator class="hidden md:block" />
            <BreadcrumbItem>
              <BreadcrumbPage>Data Fetching</BreadcrumbPage>
            </BreadcrumbItem>
          </BreadcrumbList>
        </Breadcrumb>
      </header>

      <!-- Main Content -->
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
    </SidebarInset>
  </SidebarProvider>
</template>
