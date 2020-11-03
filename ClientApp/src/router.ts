import Vue from 'vue';
import Router from 'vue-router';
import Home from './views/Home.vue';

Vue.use(Router);

export default new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/',
      name: 'home',
      component: Home,
    },
    {
      path: '/fetch-forecast-data',
      name: 'fetch-forecast-data',
      component: () => import(/* webpackChunkName: "fetch-forecast-data" */ './views/forecast/FetchForecastData.vue'),
    },
    {
      path: '/fetch-product-data',
      name: 'fetch-product-data',
      component: () => import(/* webpackChunkName: "fetch-product-data" */'./views/product/FetchProductData.vue'),
    },
  ],
});
