using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstateDapper.UI.DTOs.ProductDetailDtos;
using RealEstateDapper.UI.DTOs.ProductDtos;

namespace RealEstateDapper.UI.Controllers
{
    public class PropertyController : Controller
    {
        IHttpClientFactory _httpClientFactory;

        public PropertyController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44358/api/Products/ProductListWithCategory");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet("property/{slug}/{id}")]
        public async Task<IActionResult> PropertySingle(string slug, int id)
        {
            ViewBag.i = id;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44358/api/Products/GetProductByProductId?id=" + id);
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ResultProductDto>(jsonData);
            ViewBag.productId = values.ProductID;
            ViewBag.title1 = values.Title;
            ViewBag.price = values.Price;
            ViewBag.city = values.City;
            ViewBag.district = values.District;
            ViewBag.address = values.Address;
            ViewBag.type = values.Type;
            ViewBag.description = values.Description;
            ViewBag.slugUrl = values.SlugUrl;

            DateTime date1 = DateTime.Now;
            DateTime date2 = values.AdvertisementDate;
            TimeSpan timeSpan = date1 - date2;
            int day = timeSpan.Days;
            ViewBag.datediff = day/30 ;
            ViewBag.advertisementDate = values.AdvertisementDate ;

            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:44358/api/ProductDetails/GetProductDetailByProductId?id=" + id);
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            var values2 = JsonConvert.DeserializeObject<GetProductDetailByIdDto>(jsonData2);

            ViewBag.bathCount = values2.BathCount;
            ViewBag.badRoomCount = values2.BadRoomCount;
            ViewBag.bathCount = values2.BuildYear;
            ViewBag.roomCount = values2.RoomCount;
            ViewBag.garageSize = values2.GarageSize;
            ViewBag.buildYear = values2.BuildYear;
            ViewBag.location = values2.Location;
            ViewBag.videoUrl = values2.VideoUrl;
            ViewBag.productSize = values2.ProductSize;
            ViewBag.price = values2.Price;

            string slugFromTitle = CreateSlug(values.Title);
            ViewBag.slugUrl = slugFromTitle;
            return View();

        }

        public async Task<IActionResult> PropertyListWithSearch(string searchKeyValue, int propertyCategoryId, string city)
        {
			ViewBag.searchKeyValue = TempData["searchKeyValue"];
			ViewBag.propertyCategoryId = TempData["propertyCategoryId"];
			ViewBag.city = TempData["city"];

			searchKeyValue = TempData["searchKeyValue"].ToString();
			propertyCategoryId = int.Parse(TempData["propertyCategoryId"].ToString());
			city = TempData["city"].ToString();

			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"https://localhost:44358/api/Products/ResultProductWithSearchList?searchKeyValue={searchKeyValue}&propertyCategoryId={propertyCategoryId}&city={city}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultProductWithSearchListDto>>(jsonData);
				return View(values);
			}
			return View();
		}

        public string CreateSlug(string title)
        {
            title = title.ToLowerInvariant(); // Küçük harfe çevir
            title = title.Replace(" ", "-"); // Boşlukları tire ile değiştir
            title = System.Text.RegularExpressions.Regex.Replace(title, @"[^a-z0-9\s-]", ""); // Geçersiz karakterleri kaldır
            title = System.Text.RegularExpressions.Regex.Replace(title, @"\s+", " ").Trim(); // Birden fazla boşluğu tek boşluğa indir ve kenar boşluklarını kaldır
            title = System.Text.RegularExpressions.Regex.Replace(title, @"\s", "-"); // Boşlukları tire ile değiştir

            return title;
        }
    }
}
