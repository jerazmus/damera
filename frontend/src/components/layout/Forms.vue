<template>
  <div class="forms">
    <Login />
    <LoginOff />
    <Register />
    <RegisterOff />
    <MovingBlock />
  </div>
</template>

<script>
import Login from "../actions/Login.vue";
import Register from "../actions/Register.vue";
import LoginOff from "./LoginOff.vue";
import RegisterOff from "./RegisterOff.vue";
import MovingBlock from "./MovingBlock.vue";

export default {
  name: "Forms",
  components: {
    Login,
    LoginOff,
    Register,
    RegisterOff,
    MovingBlock,
  },
  data() {
    return {};
  },
  methods: {},
};
</script>

<style scoped>
.forms {
  width: 70%;
  height: auto;
  min-height: 30vh;
  background-color: rgba(0, 0, 0, 1);
  color: white;
  margin: auto;
  top: 40%;
  left: 15%;
  z-index: 9999;
  position: absolute;
  padding: 20px;
  box-shadow: rgba(0, 0, 0, 0.6) 0px 5px 15px;
}

/* Extra small devices (phones, 600px and down) */
@media only screen and (max-width: 600px) {
  .forms {
    width: 100vw;
    min-height: 50vh;
    left: 0%;
    top: 35%;
    padding: 0;
  }
}

/* Small devices (portrait tablets and large phones, 600px and up) */
@media only screen and (min-width: 600px) and (max-width: 767px) {
  .forms {
    width: 100vw;
    min-height: 50vh;
    left: 0%;
    top: 35%;
    padding: 0;
  }
}

/* Medium devices (landscape tablets, 768px and up) */
@media only screen and (min-width: 768px) and (max-width: 992px) {
  .forms {
    width: 100vw;
    min-height: 30vh;
    left: 0%;
    top: 35%;
    padding: 0;
  }
}

/* Large devices (laptops/desktops, 992px and up) */
@media only screen and (min-width: 993px) and (max-width: 1199px) {
  .forms {
    width: 100vw;
    min-height: 25vh;
    left: 0%;
    top: 25%;
    padding: 0;
  }
}

/* Extra large devices (large laptops and desktops, 1200px and up) */
@media only screen and (min-width: 1200px) {
}
</style>
