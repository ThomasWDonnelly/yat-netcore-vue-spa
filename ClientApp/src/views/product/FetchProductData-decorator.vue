<template>
  <v-container fluid>
    <v-slide-y-transition mode="out-in">
      <v-row>
        <v-col>
          <h1>Product List</h1>
          <p>This component demonstrates fetching data from the server.</p>

          <v-data-table
            :headers="headers"
            :items="products"
            hide-default-footer
            :loading="loading"
            class="elevation-1"
          >
            <v-progress-linear v-slot:progress color="blue" indeterminate></v-progress-linear>
            <template v-slot:item.id="{ item }">
              <td>{{ item.id | id }}</td>
            </template>
            <template v-slot:item.name="{ item }">
              <td>{{ item.name | name }}</td>
            </template>
            <template v-slot:item.description="{ item }">
              <td>{{ item.description | description }}</td>
            </template>
            <template v-slot:item.price="{ item }">
              <td>{{ item.price | price }}</td>
            </template>
            <!-- <template v-slot:item.createdBy="{ item }">
              <td>{{ item.createdBy | createdBy }}</td>
            </template>
            <template v-slot:item.createdOn="{ item }">
              <td>{{ item.createdOn | createdOn }}</td>
            </template> -->
          </v-data-table>
        </v-col>
      </v-row>
    </v-slide-y-transition>

    <v-alert
      :value="showError"
      type="error"
      v-text="errorMessage"
    >
      This is an error alert.
    </v-alert>
    
    <v-alert
      :value="showError"
      type="warning"
    >
      Are you sure you're using ASP.NET Core endpoint? (default at <a href="http://localhost:5000/fetch-product-data">http://localhost:5000</a>)<br>
      API call would fail with status code 404 when calling from Vue app (default at <a href="http://localhost:8080/fetch-product-data">http://localhost:8080</a>) without devServer proxy settings in vue.config.js file.
    </v-alert>   
       
  </v-container>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import { Product } from '../../models/Product';

@Component({})
export default class FetchProductDataView extends Vue {
  private loading: boolean = true;
  private showError: boolean = false;
  private errorMessage: string = 'Error while loading product data.';
  private products: Product[] = [];
  private headers = [
    { text: 'Id', value: 'id' },
    { text: 'Name', value: 'name' },
    { text: 'Description', value: 'description' },
    { text: 'Price', value: 'price' },
    // { text: 'Created By', value: 'createdBy' },
    // { text: 'Created On', value: 'createdOn' },
  ];

  private async created() {
    await this.fetchProductData();
  }

  private async fetchProductData() {
    try {
      const response = await this.$axios.get<Product[]>('api/Product');
      this.products = response.data;
    } catch (e) {
      this.showError = true;
      this.errorMessage = `Error while loading product data: ${e.message}.`;
    }
    this.loading = false;
  }
}
</script>
