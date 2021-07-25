import Vue from 'vue'
import Router from 'vue-router'
import Home from '../components/pages/Home.vue'
import Dashboard from '../components/pages/Dashboard.vue'

Vue.use(Router)

const router = new Router({
    mode: 'history',
    base: process.env.BASE_URL,
    routes: [
        {
            path: '/',
            name: 'Home',
            component: Home
        },
        {
            path: '/dashboard',
            name: 'Dashboard',
            component: Dashboard
        }
    ]
})

export default router