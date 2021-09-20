<template>
  <div class="account">
    <Navbar />
    <AccountInfo />
  </div>
</template>

<script>
import Navbar from '../actions/Navbar.vue'
import AccountInfo from '../actions/AccountInfo.vue'

export default {
  name: 'Account',
  components: {
    Navbar,
    AccountInfo,
  },
}
</script>

<style scoped>
.account {
  margin: 0;
  font-family: 'Poppins', sans-serif;
}

/* Extra small devices (phones, 600px and down) */
@media only screen and (max-width: 600px) {
  .account {
    height: 100vh;
    width: 100vw;
    margin: 0;
    padding: 0;
  }
}

/* Small devices (portrait tablets and large phones, 600px and up) */
@media only screen and (min-width: 600px) and (max-width: 767px) {
  .account {
    height: 100vh;
    width: 100vw;
    margin: 0;
    padding: 0;
  }
}

/* Medium devices (landscape tablets, 768px and up) */
@media only screen and (min-width: 768px) and (max-width: 992px) {
  .account {
    height: 100vh;
    width: 100vw;
    margin: 0;
    padding: 0;
  }
}

/* Large devices (laptops/desktops, 992px and up) */
@media only screen and (min-width: 993px) and (max-width: 1199px) {
  .account {
    height: 100vh;
    width: 100vw;
    margin: 0;
    padding: 0;
  }
}

/* Extra large devices (large laptops and desktops, 1200px and up) */
@media only screen and (min-width: 1200px) and (max-width: 1400px) {
  #title {
    font-size: 160px;
  }
}
</style>
