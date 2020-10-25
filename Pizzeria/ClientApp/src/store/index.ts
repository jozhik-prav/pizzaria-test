import Vue from "vue";
import Vuex from "vuex";

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    basket: Array<any>()
  },
  mutations: {
    addPizza(state, payload) {
      state.basket.push({
        pizza: payload.pizza,
        count: payload.count
      });
    }
  },
  actions: {},
  modules: {}
});
