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
  modules: {},
  getters: {
    totalSum: state => {
      return state.basket.map(x => x.pizza.price * x.count).reduce((a, b) => a + b)
    }
  }
});
