import { OrderLine } from '@/Types';
import Vue from "vue";
import Vuex from "vuex";

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    basket: Array<OrderLine>()
  },
  mutations: {
    addPizza(state, payload) {
      const orderLine = state.basket.find(x => x.pizza.id === payload.pizza.id);
      if (orderLine) 
        orderLine.count++
      else {
        state.basket.push({
        pizza: payload.pizza,
        count: payload.count
      });
      }
    },
    incrementCountPizza(_, orderLine) {
        orderLine.count++
    },
    decrementCountPizza(_, orderLine) { 
        orderLine.count--
    },
    deleteOrderLine(state, index) {
        state.basket.splice(index, 1)
    }
  },
  actions: {
    incrementCountPizza({ commit, state, getters }, id) {
      const index = getters.findOrdelLineByIndex(id);
      if (index >= 0)
        commit("incrementCountPizza", state.basket[index])
      else 
        console.error("Этого товара нет в корзине")
    },
    decrementCountPizza({ commit, state, getters }, id) {
      const index = getters.findOrdelLineByIndex(id);
      if (index >= 0) {
        const orderLine = state.basket[index];
        if (orderLine.count == 1) 
          commit("deleteOrderLine", index)
        else
          commit("decrementCountPizza", orderLine) 
      }
    },
    deleteOrderLine({ commit, state, getters }, id) {
      const index = getters.findOrdelLineByIndex(id);
      if (index >= 0)
        commit("deleteOrderLine", index)
    }
  },
  getters: {
    totalSum: (state, getters): number => {
      return state.basket.map(x => x.pizza.price * x.count).reduce((a, b) => a + b, 0) - getters.discountSum;
    },
    discountSum: (state): number => {
      return state.basket.map(x => (x.pizza.price - x.pizza.discountPrice) * x.count).reduce((a, b) => a + b, 0)
    },
    positionCount: (state): number => {
      return state.basket.length
    },
    basketIsEmpty: (_, getters): boolean => {
      return getters.positionCount === 0
    },
    findOrdelLineByIndex: state => (id: string): number => {
      return state.basket.findIndex(x => x.pizza.id === id)
    }
  }
});
