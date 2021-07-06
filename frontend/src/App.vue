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
  background: url("./assets/wallpaper.jpg");
  background-position: center;
  background-attachment: fixed;
  background-repeat: no-repeat;
  background-size: cover;
}

#cover {
  background-color: rgba(0, 0, 0, 0.6);
  margin: 0;
  padding: 0;
  height: 100vh;
  width: 100vw;
}
</style>
