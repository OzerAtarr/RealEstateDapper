using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstateDapper.UI.DTOs.PropertyImageDtos;

namespace RealEstateDapper.UI.ViewComponents.PropertySingle
{
    public class _ProportySliderComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ProportySliderComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44358/api/ProductImages?productId=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ProportyImageDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
