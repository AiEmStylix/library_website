import type { LucideProps } from 'lucide-vue-next'
import type { Component } from 'vue'


export interface NavItem {
  title: string
  url: string
  icon: Component<LucideProps>
  isActive?: boolean
}

export interface NavGroup {
  title: string
  items: NavItem[]
}

