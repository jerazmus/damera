<template>
  <div class="home">
    <Login />
    <Register />
    <GameScreen />
  </div>
</template>

<script>
import Login from "./Login.vue";
import Register from "./Register.vue";
import GameScreen from "./GameScreen.vue";

export default {
  name: "Home",
  components: {
    Login,
    Register,
    GameScreen,
  },
};
</script>

<style scoped>
.home {
  margin: 0;
}
</style>
