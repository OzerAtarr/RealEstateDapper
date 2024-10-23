using Microsoft.AspNetCore.SignalR;
using System.Net.Http;

namespace RealEstateDapper.API.Hubs
{
    public class SignalRHub : Hub
    {
        private IHttpClientFactory _httpClientFactory;

        public SignalRHub(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task SendCategoryCount()
        {
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("https://localhost:44358/api/Statistics/CategoryCount");
            var value1 = await responseMessage1.Content.ReadAsStringAsync();
            await Clients.All.SendAsync("ReceiveCategoryCount", value1);
        }

    }
}
