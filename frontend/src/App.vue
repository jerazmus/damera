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
  /*background-color: rgba(255, 255, 255, 1);*/
  margin: 0;
  padding: 0;
  height: 100vh;
  width: 70vw;
  position: absolute;
  right: 0;
  box-shadow: rgba(0, 0, 0, 0.6) 0px 5px 15px;
}
</style>
