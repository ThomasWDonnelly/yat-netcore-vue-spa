import Vue from 'vue';
import Vuex, { StoreOptions } from 'vuex';
import { RootState } from './types';

Vue.use(Vuex);

// NOTE: Vuex structure based on https://codeburst.io/vuex-and-typescript-3427ba78cfa8
const store: StoreOptions<RootState> = {
  state: {
    version: '1.0.0',
  },
  modules: {
    // TODO: add store modules here, e.g. './a-store-module/index',
  },
};

export default new Vuex.Store<RootState>(store);
