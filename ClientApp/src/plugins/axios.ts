'use strict';
import Vue from 'vue';
import axios, { AxiosInstance, AxiosRequestConfig } from 'axios';

// // Full config:  https://github.com/axios/axios#request-config
// axios.defaults.baseURL = process.env.baseURL || process.env.apiUrl || '';
// axios.defaults.headers.common['Authorization'] = AUTH_TOKEN;
// axios.defaults.headers.post['Content-Type'] = 'application/x-www-form-urlencoded';

const config = {
  baseURL: process.env.baseURL || process.env.apiUrl || '',
  // timeout: 60 * 1000,    // Timeout
  // withCredentials: true, // Check cross-site Access-Control
};

// tslint:disable-next-line: variable-name
const _axios = axios.create(config);

// Add a response interceptor
_axios.interceptors.request.use(
  (conf: AxiosRequestConfig) => conf,
  (error: any) => Promise.reject(error),
);

_axios.interceptors.response.use(
  (response: any) => response,
  (error: any) => Promise.reject(error),
);

function AxiosPlugin(vue: typeof Vue, options?: any): void {
  vue.prototype.$axios = _axios;
}

declare module 'vue/types/vue' {
  interface Vue {
    $axios: AxiosInstance;
  }
}

Vue.use(AxiosPlugin);

export default AxiosPlugin;
