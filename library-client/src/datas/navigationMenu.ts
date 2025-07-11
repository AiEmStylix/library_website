import type { NavGroup } from '@/types/navigations'
import {
  Calendar,
  Settings,
  FileText,
  BookOpen,
  Users,
  Building2,
  UserCheck,
  BarChart3,
  House,
} from 'lucide-vue-next'

export const navMain: NavGroup[] = [
  {
    title: 'Home',
    items: [
      {
        title: 'Home',
        url: '/dashboard',
        icon: House,
        isActive: true,
      },
    ],
  },
  {
    title: 'Library Management',
    items: [
      {
        title: 'Books',
        url: '/books',
        icon: BookOpen,
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
]
