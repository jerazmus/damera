<template>
  <div class="account-info">
    <p class="title">Account Information</p>
    <p class="emailTitle">
      Email
      <span v-if="!emailShow" @click="emailVisible">[show]</span>
      <span v-if="emailShow" @click="emailVisible">[hide]</span>
    </p>
    <p class="email" v-if="emailShow" data-testuniquename="passwrd">
      {{ this.$store.state.userEmail }}
    </p>
    <p class="email" v-if="!emailShow" data-testuniquename="passwrd">
      {{ this.hiddenEmail }}
    </p>
    <p class="password">Change password</p>
    <b-form @submit.prevent="changePassword">
      <b-form-group>
        <b-form-input
          id="input-1"
          v-model="oldPassword"
          type="password"
          placeholder="Old password"
          required
        ></b-form-input>

        <b-form-invalid-feedback :state="passwordCheck">
          Wrong password!
        </b-form-invalid-feedback>
      </b-form-group>

      <b-form-group>
        <b-form-input
          id="input-2"
          v-model="newPassword"
          type="password"
          placeholder="New password"
          :state="passwordLength"
          required
        ></b-form-input>

        <b-form-invalid-feedback
          :state="passwordLength"
          v-if="this.newPassword != ''"
        >
          Password must be over 3 characters!
        </b-form-invalid-feedback>
      </b-form-group>

      <b-form-group>
        <b-form-input
          id="input-3"
          v-model="repeatPassword"
          type="password"
          placeholder="Repeat new password"
          :state="matchingPasswords"
          required
        ></b-form-input>

        <b-form-invalid-feedback
          id="input-live-feedback"
          v-if="this.newPassword != ''"
        >
          Passwords don't match!
        </b-form-invalid-feedback>
      </b-form-group>
      <b-button type="submit" variant="primary" class="shadow-none"
        >Change password</b-button
      >
    </b-form>
  </div>
</template>

<script>
import Vue from 'vue'
import axios from 'axios'
import VueAxios from 'vue-axios'

Vue.use(VueAxios, axios)

export default {
  name: 'AccountInfo',
  components: {},
  data() {
    return {
      oldPassword: '',
      newPassword: '',
      repeatPassword: '',
      apiUrl: 'https://localhost:44333/api/User/',
      passwordCheck: true,
      emailShow: false,
    }
  },
  computed: {
    matchingPasswords() {
      return this.newPassword == this.repeatPassword ? true : false
    },
    passwordLength() {
      if (this.newPassword == '') return true
      else if (this.newPassword.length < 4 && this.newPassword.length > 0)
        return false
      else return true
    },
    hiddenEmail() {
      return this.$store.state.userEmail.replace(/./g, '*')
    },
  },
  methods: {
    changePassword() {
      this.passwordCheck = true
      if (this.matchingPasswords && this.passwordLength) {
        let oldUserJSON = {
          id: this.$store.state.userID,
          email: this.$store.state.userEmail,
          password: this.oldPassword,
        }
        let newUserJSON = {
          id: this.$store.state.userID,
          email: this.$store.state.userEmail,
          password: this.newPassword,
        }
        axios
          .post(`${this.apiUrl}VerifyUser`, oldUserJSON)
          .then((response) => {
            return response.data
          })
          .then(() => {
            axios
              .put(`${this.apiUrl}UpdateUser`, newUserJSON)
              .then((response) => {
                return response.data
              })
              .then(() => {
                this.oldPassword = ''
                this.newPassword = ''
                this.repeatPassword = ''
              })
              .catch((error) => {
                console.log(error)
              })
          })
          .catch((error) => {
            if (error.response.status == 500) {
              this.passwordCheck = false
            }
          })
      }
    },
    emailVisible() {
      if (this.emailShow == false) {
        this.emailShow = true
      } else {
        this.emailShow = false
      }
    },
  },
}
</script>

<style scoped>
.account-info {
  width: 30vw;
  height: 55vh;
  left: 35%;
  top: 20%;
  position: absolute;
  margin: 0;
  font-family: 'Poppins', sans-serif;
  text: black;
  padding: 1%;
  box-shadow: rgba(0, 0, 0, 0.6) 0px 5px 15px;
}

.title {
  font-size: 35px;
}

.emailTitle,
.password {
  font-size: 25px;
}

.email {
}

span {
  font-size: 11px;
  user-select: none;
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

.btn-primary {
  background-color: rgb(241, 163, 85) !important;
  border-color: transparent !important;
  margin-top: 1%;
  user-select: none;
}

.btn-primary:hover {
  background-color: rgba(241, 163, 85, 0.77) !important;
  border-color: transparent !important;
}

/* Extra small devices (phones, 600px and down) */
@media only screen and (max-width: 600px) {
}

/* Small devices (portrait tablets and large phones, 600px and up) */
@media only screen and (min-width: 600px) and (max-width: 767px) {
}

/* Medium devices (landscape tablets, 768px and up) */
@media only screen and (min-width: 768px) and (max-width: 992px) {
}

/* Large devices (laptops/desktops, 992px and up) */
@media only screen and (min-width: 993px) and (max-width: 1199px) {
}

/* Extra large devices (large laptops and desktops, 1200px and up) */
@media only screen and (min-width: 1200px) and (max-width: 1400px) {
}
</style>
