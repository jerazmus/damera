<template>
  <div class="home">
    <p id="title">dam<span class="era">era</span>.</p>
    <Forms />
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
}

#title {
  position: absolute;
  font-size: 200px;
  left: 14%;
  top: 5%;
  color: rgb(241, 163, 85);
}

.era {
  color: black;
}
</style>
