<template>
  <div class="account-info">
    <p>{{ this.$store.state.userEmail }}</p>
    <p>{{ this.$store.state.userID }}</p>
  </div>
</template>

<script>
export default {
  name: 'AccountInfo',
  components: {},
}
</script>

<style scoped>
.account-info {
  margin: 0;
  font-family: 'Poppins', sans-serif;
  text: black;
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
