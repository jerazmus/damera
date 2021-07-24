<template>
  <transition name="slide-fade">
    <div class="login" v-if="this.$store.state.loginView">
      <h1>log in<span>.</span></h1>
      <b-form @submit="login" @reset="register">
        <b-form-group>
          <b-form-input
            id="input-1"
            v-model="email"
            type="email"
            placeholder="Email"
            required
          ></b-form-input>
        </b-form-group>

        <b-form-group>
          <b-form-input
            id="input-2"
            v-model="password"
            type="password"
            placeholder="Password"
            required
          ></b-form-input>
        </b-form-group>

        <b-button class="forget">Forgot your password? </b-button>

        <b-button
          type="submit"
          variant="primary"
          class="shadow-none login-button"
          >LOG IN
        </b-button>
      </b-form>
    </div>
  </transition>
</template>

<script>
export default {
  name: "Login",
  data() {
    return {
      email: "",
      password: "",
    };
  },
  methods: {
    login() {
      // tutaj strzał do backendu z loginem
    },
    register() {
      this.$store.state.registerView = true;
      this.$store.state.loginView = false;
    },
  },
  mounted() {
    this.email = "";
    this.password = "";
  },
};
</script>

<style scoped>
.login {
  width: 45%;
  height: 120%;
  color: black;
  margin: auto;
  top: -10%;
  left: 50%;
  z-index: 10;
  position: absolute;
  padding: 20px;
}

h1 {
  margin-top: 0%;
  margin-bottom: 5%;
  color: rgb(241, 163, 85);
  user-select: none; 
}

span {
  color: black;
}

button {
  margin: 1px;
  margin-top: 5%;
  user-select: none; 
}

.forget,
.forget:focus {
  background-color: transparent !important;
  border: none;
  color: rgba(0, 0, 0, 0.7) !important;
  margin-right: 10%;
  outline-style: none;
  box-shadow: none;
}

.login-button {
  width: 30%;
}

input {
  background-color: rgba(0, 0, 0, 0);
  border: none;
  border-bottom: 2px solid rgba(0, 0, 0, 0.15);
  border-radius: 0 !important;
  padding: 0;
  color: rgba(0, 0, 0, 0.15) !important;
  width: 90%;
}

input:focus {
  background-color: rgb(0, 0, 0, 0.1);
  border: none;
  border-bottom: 2px solid rgba(0, 0, 0, 0.15);
  outline-style: none;
  box-shadow: none;
}

.btn-primary {
  background-color: rgb(241, 163, 85);
  border-color: transparent !important;
  user-select: none; 
}

.btn-primary:hover {
  background-color: rgba(241, 163, 85, 0.77) !important;
  border-color: transparent !important;
}

.slide-fade-enter-active {
  transition: all 1s ease;
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
  .login {
    width: 75%;
    height: 120%;
    color: black;
    margin: auto;
    top: -10%;
    left: 20%;
    z-index: 10;
    position: absolute;
    padding: 20px;
  }

  .login-button {
    width: 100%;
  }

  .forget {
    width: 100%;
  }

  h1 {
    margin-top: 15%;
  }

  input {
    width: 100%;
  }
}

/* Small devices (portrait tablets and large phones, 600px and up) */
@media only screen and (min-width: 600px) {

}

/* Medium devices (landscape tablets, 768px and up) */
@media only screen and (min-width: 768px) {

}

/* Large devices (laptops/desktops, 992px and up) */
@media only screen and (min-width: 992px) {

}

/* Extra large devices (large laptops and desktops, 1200px and up) */
@media only screen and (min-width: 1200px) {

}
</style>
