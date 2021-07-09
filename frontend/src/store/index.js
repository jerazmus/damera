import Vue from "vue";
import Vuex from "vuex";

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    register: false,
    login: true,
    logged: false,
    userID: null,
    userEmail: null,
  },
  getters: {},
  mutations: {},
  actions: {},
});
