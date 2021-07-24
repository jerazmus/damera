<template>
  <div id="app">
    <div id="cover">
      <router-view />
    </div>
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
  background: url("./assets/phone.jpg");
  background-position: -5% 0%;
  background-attachment: fixed;
  background-repeat: no-repeat;
  background-size: 40vw 110vh;
}

#cover {
  background-color: rgba(255,255,255, 1);
  margin: 0;
  padding: 0;
  height: 100vh;
  width: 70vw;
  position: absolute;
  right: 0;
  box-shadow: rgba(0, 0, 0, 0.6) 0px 5px 15px;
}

/* Extra small devices (phones, 600px and down) */
@media only screen and (max-width: 600px) {
  * {
    margin: 0;
  }

  body, html {
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
    background: none;
    height: auto;
    width: 100vw;
    
  }

  #cover {
    height: 100vh;
    width: 100vw;
    box-shadow: none;
    right: auto;
  }
}

/* Small devices (portrait tablets and large phones, 600px and up) */
@media only screen and (min-width: 600px) {

}

/* Medium devices (landscape tablets, 768px and up) */
@media only screen and (min-width: 768px) {

}

/* Large devices (laptops/desktops, 992px and up) */
@media only screen and (min-width: 992px) {

}

/* Extra large devices (large laptops and desktops, 1200px and up) */
@media only screen and (min-width: 1200px) {

}
</style>
