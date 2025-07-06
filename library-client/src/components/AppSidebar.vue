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
} from 'lucide-vue-next'
import {
  Sidebar,
  SidebarContent,
  SidebarGroup,
  SidebarGroupContent,
  SidebarGroupLabel,
  SidebarMenu,
  SidebarMenuButton,
  SidebarMenuItem,
  SidebarRail,
} from '@/components/ui/sidebar'

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
    <SidebarRail />
  </Sidebar>
</template>
