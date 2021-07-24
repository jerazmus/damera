<template>
  <transition name="slide-fade">
    <div
      class="left"
      v-bind:class="{ right: this.$store.state.loginView }"
    ></div>
  </transition>
</template>

<script>
import Vue from "vue";
import axios from "axios";
import VueAxios from "vue-axios";

Vue.use(VueAxios, axios);

export default {
  name: "Moving",
  data() {
    return {};
  },
};
</script>

<style scoped>
.left,
.right {
  width: 45%;
  height: 120%;
  background-color: rgba(255, 255, 255, 1);
  color: black;
  margin: auto;
  top: -10%;
  z-index: 8;
  position: absolute;
  padding: 20px;
  box-shadow: rgba(0, 0, 0, 0.6) 0px 5px 15px;
  transition: left 0.8s;
}

.left {
  left: 5%;
}

.right {
  left: 50%;
}

.slide-fade-enter-active {
  transition: all 0.2s ease;
}

.slide-fade-leave-active {
  transition: all 0.2s;
}

.slide-fade-enter,
.slide-fade-leave-to {
  transform: translateX(0px);
  opacity: 0;
}

/* Extra small devices (phones, 600px and down) */
@media only screen and (max-width: 600px) {
  .left,
  .right {
    width: 75%;
  }

  .left {
    left: 5%;
  }

  .right {
    left: 20%;
  }
}

/* Small devices (portrait tablets and large phones, 600px and up) */
@media only screen and (min-width: 600px) and (max-width: 767px) {
  .left,
  .right {
    width: 75%;
  }

  .left {
    left: 5%;
  }

  .right {
    left: 20%;
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
