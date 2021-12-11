<template>
  <transition name="slide-fade">
    <div class="register" v-if="this.$store.state.registerView">
      <b-form @submit.prevent="register" @reset.prevent="cancel">
        <h1>register<span>.</span></h1>
        <b-form-group>
          <b-form-input
            id="input-1"
            v-model="email"
            type="email"
            placeholder="Email"
            required
          ></b-form-input>

          <b-form-invalid-feedback :state="emailCheck">
            Email is already used!
          </b-form-invalid-feedback>
        </b-form-group>

        <b-form-group>
          <b-form-input
            id="input-2"
            v-model="password"
            type="password"
            placeholder="Password"
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

        <b-form-group>
          <b-form-input
            id="input-3"
            v-model="repeatPassword"
            type="password"
            placeholder="Repeat Password"
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

        <transition name="slide-fade">
          <p class="user-created" v-if="userCreated">
            User {{ emailCreated }} created!
          </p>
        </transition>

        <b-button type="submit" variant="primary" class="shadow-none"
          >SIGN UP</b-button
        >
      </b-form>
    </div>
  </transition>
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
      apiUrl: "https://localhost:44333/api/User/",
      emailCheck: true,
      userCreated: false,
      emailCreated: null,
    };
  },
  computed: {
    matchingPasswords() {
      return this.password == this.repeatPassword ? true : false;
    },
    passwordLength() {
      if (this.password == "") return true;
      else if (this.password.length < 4 && this.password.length > 0)
        return false;
      else return true;
    },
  },
  methods: {
    async register() {
      if (this.passwordLength) {
        if (this.matchingPasswords) {
          let userJSON = { email: this.email, password: this.password };
          axios
            .post(`${this.apiUrl}AddUser`, userJSON)
            .then((response) => {
              return response.data;
            })
            .then((data) => {
              this.userCreate(data.email);
            })
            .catch((error) => {
              if (error.response.status == 500) {
                this.emailCheck = false;
              }
            });
        }
      }
    },
    cancel() {
      (this.email = ""), (this.password = ""), (this.repeatPassword = "");
      this.$store.state.registerView = false;
      this.$store.state.loginView = true;
      this.emailCheck = true;
    },
    userCreate(email) {
      (this.email = ""), (this.password = ""), (this.repeatPassword = "");
      this.userCreated = true;
      this.emailCreated = email;
      this.emailCheck = true;
      setTimeout(() => {
        this.emailCreated = null;
        this.userCreated = false;
      }, 3000);
    },
  },
};
</script>

<style scoped>
.register {
  width: 45%;
  height: 120%;
  color: black;
  margin: auto;
  top: -10%;
  left: 5%;
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
  background-color: rgb(241, 163, 85) !important;
  border-color: transparent !important;
  margin-left: 70%;
  user-select: none;
}

.btn-primary:hover {
  background-color: rgba(241, 163, 85, 0.77) !important;
  border-color: transparent !important;
}

.form-control.is-valid,
.form-control.is-valid:focus {
  background-image: none;
  border-color: transparent !important;
  outline-style: none;
  box-shadow: none;
  border: none;
  border-bottom: 2px solid rgba(0, 0, 0, 0.15) !important;
  border-radius: 0 !important;
  padding: 0;
  color: rgba(0, 0, 0, 0.15) !important;
  width: 90%;
}

.user-created {
  color: green;
  font-size: 80%;
  text-align: center;
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
  .register {
    width: 75%;
  }

  .btn-primary {
    width: 100%;
    margin: 0;
  }

  h1 {
    margin-top: 10%;
  }

  input,
  .form-control.is-valid,
  .form-control.is-valid:focus {
    width: 100%;
  }
}

/* Small devices (portrait tablets and large phones, 600px and up) */
@media only screen and (min-width: 600px) and (max-width: 767px) {
  .register {
    width: 75%;
  }

  .btn-primary {
    width: 100%;
    margin: 0;
  }

  h1 {
    margin-top: 10%;
  }

  input,
  .form-control.is-valid,
  .form-control.is-valid:focus {
    width: 100%;
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
