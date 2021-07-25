<template>
  <div id="app">
    <router-view />
  </div>
</template>

<script>
export default {
  name: "App",
  components: {},
};
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
