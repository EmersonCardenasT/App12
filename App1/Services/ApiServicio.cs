using App1.Model.RIAS;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App1.Services
{
    public class ApiServicio
    {
        private readonly HttpClient _httpClient;
        public ApiServicio()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<MDragonBall>> GetGuerrerosZAsync()
        {
            var response = await _httpClient.GetStringAsync("https://dragonball-api.com/api/characters");
            var apiResponse = JsonConvert.DeserializeObject<ApiResponse> (response);
            return apiResponse.Items;
        }
    }
}
 