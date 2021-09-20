<template>
  <div id="app">
    <router-view />
  </div>
</template>

<script>
import Vue from 'vue'
import axios from 'axios'
import VueAxios from 'vue-axios'
import cookie from 'vue-cookies'

Vue.use(VueAxios, axios)

export default {
  name: 'App',
  data() {
    return {
      apiUrl: 'https://localhost:44333/api/Token/',
    }
  },
  components: {},
  mounted() {
    let token = cookie.get('damera')
    let userToken = token.token

    axios
      .get(this.apiUrl + `Verify`, { params: { userToken } })
      .then((response) => {
        return response.data
      })
      .then((data) => {
        this.$store.state.logged = true
        this.$store.state.userEmail = data.email
        this.$store.state.userID = data.id
        this.$router.push('/dashboard')
      })
      .catch((error) => {
        if (error.response.status == 500) {
          alert('Błąd!')
        }
      })
  },
}
</script>

<style>
* {
  margin: 0;
}

body {
  margin: 0;
  padding: 0;
  overflow-y: scroll;
  scrollbar-width: none;
  -ms-overflow-style: none;
}

body::-webkit-scrollbar {
  width: 0;
  height: 0;
}

#app {
  margin: 0;
  padding: 0;
  min-height: 100vh;
  height: auto;
}

/* Extra small devices (phones, 600px and down) */
@media only screen and (max-width: 600px) {
  * {
    margin: 0;
  }

  body,
  html {
    width: 100vw;
    margin: 0;
    padding: 0;
    overflow-y: scroll;
    scrollbar-width: none;
    -ms-overflow-style: none;
  }

  body::-webkit-scrollbar {
    width: 0;
    height: 0;
  }

  #app {
    height: auto;
    width: 100vw;
  }
}

/* Small devices (portrait tablets and large phones, 600px and up) */
@media only screen and (min-width: 600px) and (max-width: 767px) {
  * {
    margin: 0;
  }

  body,
  html {
    width: 100vw;
    margin: 0;
    padding: 0;
    overflow-y: scroll;
    scrollbar-width: none;
    -ms-overflow-style: none;
  }

  body::-webkit-scrollbar {
    width: 0;
    height: 0;
  }

  #app {
    height: auto;
    width: 100vw;
  }
}

/* Medium devices (landscape tablets, 768px and up) */
@media only screen and (min-width: 768px) and (max-width: 992px) {
  * {
    margin: 0;
  }

  body,
  html {
    width: 100vw;
    margin: 0;
    padding: 0;
    overflow-y: scroll;
    scrollbar-width: none;
    -ms-overflow-style: none;
  }

  body::-webkit-scrollbar {
    width: 0;
    height: 0;
  }

  #app {
    height: auto;
    width: 100vw;
  }
}

/* Large devices (laptops/desktops, 992px and up) */
@media only screen and (min-width: 993px) and (max-width: 1199px) {
  * {
    margin: 0;
  }

  body,
  html {
    width: 100vw;
    margin: 0;
    padding: 0;
    overflow-y: scroll;
    scrollbar-width: none;
    -ms-overflow-style: none;
  }

  body::-webkit-scrollbar {
    width: 0;
    height: 0;
  }

  #app {
    height: auto;
    width: 100vw;
  }
}

/* Extra large devices (large laptops and desktops, 1200px and up) */
@media only screen and (min-width: 1200px) {
}
</style>
