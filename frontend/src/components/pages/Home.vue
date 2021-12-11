<template>
  <div class="home">
    <div id="cover">
      <p id="title">dam<span class="era">era</span>.</p>
      <Forms />
    </div>
  </div>
</template>

<script>
import Forms from "../layout/Forms.vue";

export default {
  name: "Home",
  components: {
    Forms,
  },
};
</script>

<style scoped>
.home {
  margin: 0;
  font-family: "Poppins", sans-serif;
  padding: 0;
  min-height: 100vh;
  height: auto;
  background: url("../../assets/phone.jpg");
  background-position: -5% 0%;
  background-attachment: fixed;
  background-repeat: no-repeat;
  background-size: 40vw 110vh;
}

#title {
  position: absolute;
  font-size: 200px;
  left: 14%;
  top: 5%;
  color: rgb(241, 163, 85);
  user-select: none;
}

.era {
  color: black;
}

#cover {
  background-color: rgba(255, 255, 255, 1);
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
  #title {
    font-size: 90px;
    left: auto;
    margin-left: auto;
    margin-right: auto;
    position: relative;
    text-align: center;
  }

  .home {
    height: 100vh;
    width: 100vw;
    margin: 0;
    padding: 0;
    background: none;
  }

  #cover {
    height: 100vh;
    width: 100vw;
    box-shadow: none;
    right: auto;
  }
}

/* Small devices (portrait tablets and large phones, 600px and up) */
@media only screen and (min-width: 600px) and (max-width: 767px) {
  #title {
    font-size: 90px;
    left: auto;
    margin-left: auto;
    margin-right: auto;
    position: relative;
    text-align: center;
  }

  .home {
    height: 100vh;
    width: 100vw;
    margin: 0;
    padding: 0;
    background: none;
  }

  #cover {
    height: 100vh;
    width: 100vw;
    box-shadow: none;
    right: auto;
  }
}

/* Medium devices (landscape tablets, 768px and up) */
@media only screen and (min-width: 768px) and (max-width: 992px) {
  #title {
    font-size: 120px;
    left: auto;
    margin-left: auto;
    margin-right: auto;
    position: relative;
    text-align: center;
  }

  .home {
    height: 100vh;
    width: 100vw;
    margin: 0;
    padding: 0;
    background: none;
  }

  #cover {
    height: 100vh;
    width: 100vw;
    box-shadow: none;
    right: auto;
  }
}

/* Large devices (laptops/desktops, 992px and up) */
@media only screen and (min-width: 993px) and (max-width: 1199px) {
  #title {
    font-size: 120px;
    left: auto;
    margin-left: auto;
    margin-right: auto;
    position: relative;
    text-align: center;
  }

  .home {
    height: 100vh;
    width: 100vw;
    margin: 0;
    padding: 0;
    background: none;
  }

  #cover {
    height: 100vh;
    width: 100vw;
    box-shadow: none;
    right: auto;
  }
}

/* Extra large devices (large laptops and desktops, 1200px and up) */
@media only screen and (min-width: 1200px) and (max-width: 1400px) {
  #title {
    font-size: 160px;
  }
}
</style>
