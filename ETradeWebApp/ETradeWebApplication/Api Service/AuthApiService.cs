using Core.Utilities.OperationResults;
using Core.Utilities.Security.Jwt;
using Entities.Concrete;
using Entities.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ETradeWebApplication.Api_Service
{
    public class AuthApiService
    {
        private HttpClient _httpClient;
        public AuthApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IDataResult<AccessToken>> LoginAsync(UserForLoginDto userForLoginDto)
        {
            IDataResult<AccessToken> result;
            var stringContent = new StringContent(JsonConvert.SerializeObject(userForLoginDto), Encoding.UTF8, "application/json");
            var responseMessage = await _httpClient.PostAsync("auths/login", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                result = JsonConvert.DeserializeObject<SuccessDataResult<AccessToken>>(await responseMessage.Content.ReadAsStringAsync());
            }
            else
            {
                result = new ErrorDataResult<AccessToken>();
            }
            return result;
        }

        public async Task<IDataResult<AccessToken>> RegisterAsync(UserForRegisterDto userForRegisterDto)
        {
            IDataResult<AccessToken> result;
            var stringContent = new StringContent(JsonConvert.SerializeObject(userForRegisterDto), Encoding.UTF8, "application/json");
            var responseMessage = await _httpClient.PostAsync("auths/register", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                result = JsonConvert.DeserializeObject<SuccessDataResult<AccessToken>>(await responseMessage.Content.ReadAsStringAsync());
            }
            else
            {
                result = new ErrorDataResult<AccessToken>();
            }
            return result;
        }

    }
}
