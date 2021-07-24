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
</style>
