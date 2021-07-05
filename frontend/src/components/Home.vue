<template>
  <div class="home">
    <Login />
    <Register />
  </div>
</template>

<script>
import Login from './Login.vue'
import Register from './Register.vue'

export default {
  name: 'Home',
  components: {
    Login,
    Register
  },
}
</script>

<style scoped>

.home {
  margin: 0;
}

</style>
