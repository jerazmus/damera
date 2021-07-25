<template>
  <div class="dashboard">
    <p>{{ this.$store.state.userEmail }}</p>
    <p>{{ this.$store.state.userID }}</p>
  </div>
</template>

<script>
export default {
  name: "Dashboard",
  components: {},
};
</script>

<style scoped>
.dashboard {
  margin: 0;
  font-family: "Poppins", sans-serif;
}

/* Extra small devices (phones, 600px and down) */
@media only screen and (max-width: 600px) {
  .dashboard {
    height: 100vh;
    width: 100vw;
    margin: 0;
    padding: 0;
  }
}

/* Small devices (portrait tablets and large phones, 600px and up) */
@media only screen and (min-width: 600px) and (max-width: 767px) {
  .dashboard {
    height: 100vh;
    width: 100vw;
    margin: 0;
    padding: 0;
  }
}

/* Medium devices (landscape tablets, 768px and up) */
@media only screen and (min-width: 768px) and (max-width: 992px) {
  .dashboard {
    height: 100vh;
    width: 100vw;
    margin: 0;
    padding: 0;
  }
}

/* Large devices (laptops/desktops, 992px and up) */
@media only screen and (min-width: 993px) and (max-width: 1199px) {
  .dashboard {
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
