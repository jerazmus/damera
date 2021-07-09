<template>
  <div class="login" v-if="this.$store.state.login">
    <b-form @submit="login" @reset="register">
      <b-form-group
        id="input-group-1"
        label="Email address:"
        label-for="input-1"
      >
        <b-form-input
          id="input-1"
          v-model="email"
          type="email"
          placeholder="Enter email"
          required
        ></b-form-input>
      </b-form-group>

      <b-form-group id="input-group-2" label="Password:" label-for="input-2">
        <b-form-input
          id="input-2"
          v-model="password"
          type="password"
          placeholder="Enter password"
          required
        ></b-form-input>
      </b-form-group>

      <b-button type="submit" variant="primary" class="shadow-none"
        >Login</b-button
      >
      <b-button type="reset" variant="outline-primary" class="shadow-none"
        >Register</b-button
      >
    </b-form>
  </div>
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
      this.$store.state.register = true;
      this.$store.state.login = false;
    },
  },
  mounted() {
    this.email = "";
    this.password = "";
  }
};
</script>

<style scoped>
.login {
  width: 20%;
  height: auto;
  background-color: rgba(0, 0, 0, 0.6);
  color: white;
  margin: auto;
  top: 30%;
  left: 40%;
  z-index: 10;
  position: absolute;
  padding: 20px;
  border: 1px solid black;
  border-radius: 5.8%;
}

button {
  margin: 1px;
}

input {
  background-color: rgba(0, 0, 0, 0.5);
  border: rgba(0, 0, 0, 0.5);
}

input:focus {
  background-color: rgb(29, 29, 29);
  border: rgba(0, 0, 0, 0.5);
  outline-style: none;
  box-shadow: none;
}

.btn-primary {
  background-color: rgba(0, 0, 0, 0.7) !important;
  border-color: rgb(53, 53, 53) !important;
}

.btn-primary:hover {
  background-color: rgb(31, 31, 31) !important;
  border-color: rgb(53, 53, 53) !important;
}

.btn-outline-primary,
.btn-outline-primary:hover {
  background-color: rgba(0, 0, 0, 0) !important;
  border-color: rgba(0, 0, 0, 0) !important;
  color: white !important;
}
</style>
