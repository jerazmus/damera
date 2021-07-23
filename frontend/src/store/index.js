import Vue from "vue";
import Vuex from "vuex";

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    registerView: true,
    loginView: false,
    logged: false,
    userEmail: null,
  },
  getters: {},
  mutations: {},
  actions: {},
});
