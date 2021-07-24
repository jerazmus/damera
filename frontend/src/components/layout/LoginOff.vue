<template>
  <transition name="slide-fade">
    <div class="login-off" v-if="!this.$store.state.loginView">
      <h2>Already have an account?</h2>
      <p>Log in and start using the site!</p>
      <button @click="loginOn">LOGIN</button>
    </div>
  </transition>
</template>

<script>
export default {
  name: "Login",
  data() {
    return {};
  },
  methods: {
    loginOn() {
      this.$store.state.registerView = false;
      this.$store.state.loginView = true;
    },
  },
};
</script>

<style scoped>
.login-off {
  width: 45%;
  height: 100%;
  background-color: rgba(0, 0, 0, 0);
  color: black;
  margin: auto;
  top: 0%;
  left: 50%;
  z-index: 10;
  position: absolute;
  padding: 20px;
  padding-top: 7%;
  text-align: right;
}

button {
  background-color: transparent;
  border: 2px solid rgba(200, 200, 200, 1);
  padding: 7px 15px;
  width: 40%;
}

h2,
p,
button {
  color: white;
}

.slide-fade-enter-active {
  transition: all 1.5s ease;
}

.slide-fade-leave-active {
  transition: all 0s;
}

.slide-fade-enter,
.slide-fade-leave-to {
  transform: translateX(0px);
  opacity: 0;
}
</style>
