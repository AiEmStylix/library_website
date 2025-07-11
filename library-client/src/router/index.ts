import { createRouter, createWebHistory } from 'vue-router'
import HelloWorld from '@/views/dashboard/index.vue'
import HomePage from '@/views/dashboard/HomePage.vue'
import AuthorsPage from '@/views/dashboard/AuthorsPage.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/dashboard',
      name: 'home',
      component: HelloWorld,
      children: [
        { path: '', component: HomePage },
        { path: '/authors', component: AuthorsPage },
      ],
    },
  ],
})

export default router
