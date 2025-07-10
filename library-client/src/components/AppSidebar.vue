<script setup lang="ts">
import {
  Calendar,
  Home,
  Inbox,
  Search,
  Settings,
  FileText,
  BookOpen,
  Users,
  Building2,
  UserCheck,
  BarChart3,
  Library,
  Moon,
} from 'lucide-vue-next'

import { Icon } from '@iconify/vue'
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
import { useColorMode } from '@vueuse/core'
import Switch from './ui/switch/Switch.vue'
import { computed } from 'vue'

const data = {
  navMain: [
    {
      title: 'Library Management',
      items: [
        {
          title: 'Books',
          url: '/books',
          icon: BookOpen,
          isActive: true,
        },
        {
          title: 'Authors',
          url: '/authors',
          icon: Users,
        },
        {
          title: 'Publishers',
          url: '/publishers',
          icon: Building2,
        },
        {
          title: 'Members',
          url: '/members',
          icon: UserCheck,
        },
      ],
    },
    {
      title: 'Operations',
      items: [
        {
          title: 'Borrowing',
          url: '/borrowing',
          icon: Calendar,
        },
        {
          title: 'Returns',
          url: '/returns',
          icon: FileText,
        },
        {
          title: 'Reports',
          url: '/reports',
          icon: BarChart3,
        },
      ],
    },
    {
      title: 'System',
      items: [
        {
          title: 'Settings',
          url: '/settings',
          icon: Settings,
        },
      ],
    },
  ],
}
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
      <SidebarGroup v-for="group in data.navMain" :key="group.title">
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
