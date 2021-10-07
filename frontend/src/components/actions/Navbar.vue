<template>
  <div id="navbar">
    <div id="logo">
      <p id="title">dam<span class="era">era</span>.</p>
    </div>
    <div id="menu">
      <ul>
        <li><a @click="dashboard">Dashboard</a></li>
        <li><a @click="account">Account</a></li>
        <li><a @click="logout">Logout</a></li>

        <div class="merge-test-one">HELLO</div>
      </ul>
    </div>
  </div>
</template>

<script>
import Vue from 'vue'
import axios from 'axios'
import VueAxios from 'vue-axios'
import cookie from 'vue-cookies'

Vue.use(VueAxios, axios)

export default {
  name: 'Navbar',
  data() {
    return {
      apiUrl: 'https://localhost:44333/api/Token/',
    }
  },
  methods: {
    logout() {
      axios
        .delete(`${this.apiUrl}Logout/${this.$store.state.userID}`)
        .then((response) => {
          cookie.remove('damera')
          this.$router.push('/')
          return response.data
        })
        .catch((error) => {
          console.log(error)
          this.$router.push('/')
        })
    },
    account() {
      this.$router.push('/account')
    },
    dashboard() {
      this.$router.push('/dashboard')
    },
  },
}
</script>

<style scoped>
#navbar {
  width: 100vw;
  height: 10%;
  margin: 0;
  padding: 0;
}

#logo {
  width: 30vw;
  margin: 0;
  padding: 0;
  text-align: center;
}

#title {
  font-size: 50px;
  color: rgb(241, 163, 85);
  user-select: none;
  position: absolute;
  left: 5%;
  top: 1%;
}

.era {
  color: black;
  margin: 0;
  padding: 0;
}

p,
ul {
  margin: 0;
}

#menu {
  width: auto;
  margin: 0;
  padding: 0;
  text-align: right;
  right: 5%;
  position: absolute;
  top: 3.5%;
}

li {
  list-style: none;
  display: inline;
  margin-left: 10px;
  margin-right: 10px;
  user-select: none;
}

li:hover {
  color: rgb(241, 163, 85);
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
@media only screen and (min-width: 1200px) {
}
</style>
