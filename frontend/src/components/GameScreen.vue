<template>
  <div class="gamescreen" v-if="this.$store.state.logged">
    
  </div>
</template>

<script>
export default {
  name: 'GameScreen',
  data() {
    return {

    };
  },
  methods: {
    
  }
}
</script>

<style scoped>

.gamescreen {
  width: 60%;
  height: auto;
  min-height: 70vh;
  background-color: rgba(0,0,0,0.7);
  color: white;
  margin: auto;
  top: 10%;
  left: 20%;
  z-index: 10;
  position: absolute;
  padding: 20px;
  border: 1px solid black;
  border-radius: 3%;
}

</style>
