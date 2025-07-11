<script setup lang="ts">
import { Library } from 'lucide-vue-next'

import {
  Sidebar,
  SidebarContent,
  SidebarFooter,
  SidebarGroup,
  SidebarGroupContent,
  SidebarGroupLabel,
  SidebarMenu,
  SidebarMenuButton,
  SidebarMenuItem,
  SidebarRail,
} from '@/components/ui/sidebar'
import SidebarHeader from './ui/sidebar/SidebarHeader.vue'
import type { NavGroup } from '@/types/navigations'

interface Props {
  groups: NavGroup[]
}

const props = defineProps<Props>()
</script>
<template>
  <Sidebar variant="inset" collapsible="icon">
    <SidebarHeader>
      <SidebarMenuButton size="lg" asChild>
        <a href="/">
          <div
            class="flex aspect-square size-8 items-center justify-center rounded-lg bg-sidebar-primary text-sidebar-primary-foreground"
          >
            <Library />
          </div>
          <div class="flex flex-col gap-0.5 leading-none">
            <span class="font-semibold">LibraryMS</span>
            <span class="text-xs">Management System</span>
          </div>
        </a>
      </SidebarMenuButton>
    </SidebarHeader>
    <SidebarContent>
      <SidebarGroup v-for="group in props.groups" :key="group.title">
        <SidebarGroupLabel>
          {{ group.title }}
        </SidebarGroupLabel>
        <SidebarGroupContent>
          <SidebarMenu>
            <SidebarMenuItem v-for="item in group.items" :key="item.title">
              <SidebarMenuButton asChild :isActive="item?.isActive">
                <a :href="item.url">
                  <component :is="item.icon" />
                  <span>{{ item.title }}</span>
                </a>
              </SidebarMenuButton>
            </SidebarMenuItem>
          </SidebarMenu>
        </SidebarGroupContent>
      </SidebarGroup>
    </SidebarContent>
    <SidebarFooter>
      <SidebarMenu>
        <SidebarMenuButton> </SidebarMenuButton>
      </SidebarMenu>
    </SidebarFooter>
    <SidebarRail />
  </Sidebar>
</template>
