using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstateDapper.UI.DTOs.BottomGridDtos;

namespace RealEstateDapper.UI.ViewComponents.HomePage
{
    public class _DefaultBottomGridComponentPartial : ViewComponent
    {
        IHttpClientFactory _httpClientFactory;

        public _DefaultBottomGridComponentPartial(IHttpClientFactory httpClientFactory) 
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {   
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44358/api/BottomGrids");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBottomGridDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
