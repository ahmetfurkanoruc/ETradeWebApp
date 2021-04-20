using Core.Utilities.OperationResults;
using Entities.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ETradeWebApplication.Api_Service
{
    public class CategoryApiService
    {
        private HttpClient _httpClient;
        public CategoryApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Category>> GetListAsync()
        {
            List<Category> categoryList;

            var response = await _httpClient.GetAsync("categories/list");
            if (response.IsSuccessStatusCode)
            {
                categoryList = JsonConvert.DeserializeObject<List<Category>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                categoryList = null;
            }
            return categoryList;
        }

        public async Task<Category> GetByIdAsync(int categoryId)
        {
            Category category;

            var response = await _httpClient.GetAsync($"categories/listbyid/?categoryId={categoryId}");
            if (response.IsSuccessStatusCode)
            {
                category = JsonConvert.DeserializeObject<Category>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                category = null;
            }
            return category;
        }
        public async Task<IResult> AddAsync(Category category, string token)
        {
            IResult result;
            _httpClient.DefaultRequestHeaders.Add("Authorization", token);
            var stringContent = new StringContent(JsonConvert.SerializeObject(category), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("categories/add", stringContent);
            if (response.IsSuccessStatusCode)
            {
                result = new SuccessResult();
            }
            else
            {
                result = new ErrorResult();
            }
            return result;
        }
        public async Task<IResult> UpdateAsync(Category category, string token)
        {
            IResult result;
            _httpClient.DefaultRequestHeaders.Add("Authorization", token);
            var stringContent = new StringContent(JsonConvert.SerializeObject(category), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("categories/update", stringContent);
            if (response.IsSuccessStatusCode)
            {
                result = new SuccessResult();
            }
            else
            {
                result = new ErrorResult();
            }
            return result;
        }
        public async Task<IResult> DeleteAsync(Category category, string token)
        {
            IResult result;
            _httpClient.DefaultRequestHeaders.Add("Authorization", token);
            var stringContent = new StringContent(JsonConvert.SerializeObject(category), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"categories/delete",stringContent);
            if (response.IsSuccessStatusCode)
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
