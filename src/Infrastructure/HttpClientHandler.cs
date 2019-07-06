using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class HttpClientHandler : IHttpClientHandler
    {
        private readonly HttpClient httpClient = new HttpClient();

        public async Task<T> GetAsync<T>(string url)
        {
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(content);
            }

            return default;
        }
    }
}
