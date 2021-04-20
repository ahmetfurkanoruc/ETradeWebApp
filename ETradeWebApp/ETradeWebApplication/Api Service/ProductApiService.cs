using Core.Utilities.OperationResults;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ETradeWebApplication.Api_Service
{
    public class ProductApiService
    {
        private HttpClient _httpClient;
        public ProductApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            
            List<Product> productList;
            var responseMessage = await _httpClient.GetAsync("products/list");

            if (responseMessage.IsSuccessStatusCode)
            {
                productList = JsonConvert.DeserializeObject<List<Product>>(await responseMessage.Content.ReadAsStringAsync());
            }
            else
            {
                productList = null;
            }
            return productList;
        }

        public async Task<Product> GetByIdAsync(int productId)
        {
            Product product;
            var responseMessage = await _httpClient.GetAsync($"products/detail/?productId={productId}");

            if (responseMessage.IsSuccessStatusCode)
            {
                product = JsonConvert.DeserializeObject<Product>(await responseMessage.Content.ReadAsStringAsync());
            }
            else
            {
                product = null;
            }
            return product;
        }

        public async Task<List<Product>> GetByCategoryIdAsync(int categoryId)
        {
            List<Product> productList;
            var responseMessage = await _httpClient.GetAsync($"products/listbycategory/?categoryId={categoryId}");
            if (responseMessage.IsSuccessStatusCode)
            {
                productList = JsonConvert.DeserializeObject<List<Product>>(await responseMessage.Content.ReadAsStringAsync());
            }
            else
            {
                productList = null;
            }
            return productList;
        }

        public async Task<IResult> AddAsync(Product product, string token)
        {
            IResult result;
            _httpClient.DefaultRequestHeaders.Add("Authorization", token);
            var stringContent = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");
            var responseMessage = await _httpClient.PostAsync("products/add", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                result = new SuccessResult();
            }
            else
            {
                result = new ErrorResult();
            }
            return result;
        }

        public async Task<IResult> UpdateAsync(Product product, string token)
        {
            IResult result;
            _httpClient.DefaultRequestHeaders.Add("Authorization", token);
            var stringContent = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");
            var responseMessage = await _httpClient.PostAsync("products/update", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                result = new SuccessResult();
            }
            else
            {
                result = new ErrorResult();
            }
            return result;
        }

        public async Task<IResult> DeleteAsync(Product product, string token)
        {
            IResult result;
            _httpClient.DefaultRequestHeaders.Add("Authorization", token);
            var stringContent = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");
            var responseMessage = await _httpClient.PostAsync("products/delete", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                result = new SuccessResult();
            }
            else
            {
                result = new ErrorResult();
            }
            return result;
        }
    }
}
