<template>
  <transition name="slide-fade">
    <div class="register-off" v-if="!this.$store.state.registerView">
      <h2>Don't have an account?</h2>
      <p>Register now and start using our site!</p>
      <button @click="registerOn">REGISTER</button>
    </div>
  </transition>
</template>

<script>
import Vue from "vue";
import axios from "axios";
import VueAxios from "vue-axios";

Vue.use(VueAxios, axios);

export default {
  name: "RegisterOff",
  data() {
    return {};
  },
  methods: {
    registerOn() {
      this.$store.state.registerView = true;
      this.$store.state.loginView = false;
    },
  },
};
</script>

<style scoped>
.register-off {
  width: 45%;
  height: 100%;
  background-color: rgba(0, 0, 0, 0);
  color: black;
  margin: auto;
  top: 0%;
  left: 5%;
  z-index: 9;
  position: absolute;
  padding: 20px;
  padding-top: 7%;
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
