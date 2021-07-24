<template>
  <transition name="slide-fade">
    <div class="register-off" v-if="!this.$store.state.registerView">
      <h2>Don't have an account?</h2>
      <p>Register now and start using our site!</p>
      <button @click="registerOn">REGISTER</button>
      <span @click="registerOn">&lt;</span>
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
  user-select: none; 
}

span {
  display: none;
  user-select: none; 
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

/* Extra small devices (phones, 600px and down) */
@media only screen and (max-width: 600px) {
  h2,
  p,
  button {
    display: none;
  }

  span {
    font-size: 40px;
    color: white;
    display: block;
    border: 3px solid white;
    width: 66px;
    margin: 0;
    position: absolute;
    top: 40%;
    left: 0%;
    text-align: center;
    border-radius: 100%;
    color: rgb(241, 163, 85)
  }

  .register-off {
    padding: 0;
    left: 2%;
  }
}

/* Small devices (portrait tablets and large phones, 600px and up) */
@media only screen and (min-width: 600px) and (max-width: 767px) {
  h2,
  p,
  button {
    display: none;
  }

  span {
    font-size: 40px;
    color: white;
    display: block;
    border: 3px solid white;
    width: 66px;
    margin: 0;
    position: absolute;
    top: 40%;
    left: 0%;
    text-align: center;
    border-radius: 100%;
    color: rgb(241, 163, 85)
  }

  .register-off {
    padding: 0;
    left: 2%;
  }
}

/* Medium devices (landscape tablets, 768px and up) */
@media only screen and (min-width: 768px) and (max-width: 992px) {

}

/* Large devices (laptops/desktops, 992px and up) */
@media only screen and (min-width: 993px) and (max-width: 1199px) {

}

/* Extra large devices (large laptops and desktops, 1200px and up) */
@media only screen and (min-width: 1200px) {

}
</style>
