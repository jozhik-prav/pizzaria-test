import Vue from "vue";
import VueRouter, { RouteConfig } from "vue-router";
import Menu from "../views/Menu.vue";

Vue.use(VueRouter);

const routes: Array<RouteConfig> = [
  {
    path: "/",
    name: "Menu",
    component: Menu
  },
  {
    path: "/basket",
    name: "Basket",
    component: () =>
      import( "../views/Basket.vue")
  }
];

const router = new VueRouter({
  mode: "history",
  base: process.env.BASE_URL,
  routes
});

export default router;
