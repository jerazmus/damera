<template>
  <div class="register" v-if="this.$store.state.register">
    <b-form @submit.prevent="register" @reset.prevent="cancel">
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
          :state="passwordLength"
          required
        ></b-form-input>

        <b-form-invalid-feedback
          :state="passwordLength"
          v-if="this.password != ''"
        >
          Password must be over 3 characters!
        </b-form-invalid-feedback>
      </b-form-group>

      <b-form-group
        id="input-group-3"
        label="Repeat password:"
        label-for="input-3"
      >
        <b-form-input
          id="input-3"
          v-model="repeatPassword"
          type="password"
          placeholder="Repeat password"
          :state="matchingPasswords"
          required
        ></b-form-input>

        <b-form-invalid-feedback
          id="input-live-feedback"
          v-if="this.password != ''"
        >
          Passwords don't match!
        </b-form-invalid-feedback>
      </b-form-group>

      <b-button type="submit" variant="primary" class="shadow-none"
        >Sign up</b-button
      >
      <b-button type="reset" variant="danger" class="shadow-none"
        >Cancel</b-button
      >
    </b-form>
  </div>
</template>

<script>
import Vue from "vue";
import axios from "axios";
import VueAxios from "vue-axios";

Vue.use(VueAxios, axios);

export default {
  name: "Register",
  data() {
    return {
      email: "",
      password: "",
      repeatPassword: "",
      apiUrl: "https://localhost:5001/api/Users/",
    };
  },
  computed: {
    matchingPasswords() {
      return this.password == this.repeatPassword ? true : false;
    },
    passwordLength() {
      if (this.password == "") {
        return true;
      } else if (this.password.length < 4 && this.password.length > 0) {
        return false;
      } else {
        return true;
      }
    },
  },
  methods: {
    async register() {
      if (this.passwordLength) {
        if (this.matchingPasswords) {
          let userJSON = { email: this.email, password: this.password };
          axios.post(this.apiUrl + `AddUser`, userJSON);
          this.cancel();
        } else {
          alert("Passwords don't match!");
        }
      } else {
        alert("Password is too short!");
      }
    },
    cancel() {
      (this.email = ""), (this.password = ""), (this.repeatPassword = "");
      this.$store.state.register = false;
      this.$store.state.login = true;
    },
  },
};
</script>

<style scoped>
.register {
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
  border-radius: 5%;
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

.btn-danger,
.btn-danger:hover {
  background-color: rgba(0, 0, 0, 0) !important;
  border-color: rgba(0, 0, 0, 0) !important;
  color: white;
}

.form-control.is-valid,
.form-control.is-valid:focus {
  background-image: none;
  border-color: transparent !important;
  outline-style: none;
  box-shadow: none;
}
</style>
