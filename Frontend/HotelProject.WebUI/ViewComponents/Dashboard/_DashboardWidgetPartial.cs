using HotelProject.WebUI.Dtos.AboutDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardWidgetPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardWidgetPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5125/api/DashboardWidgets/GetStaffCount");

            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("http://localhost:5125/api/DashboardWidgets/GetBookingCount");

            var client3 = _httpClientFactory.CreateClient();    
            var responseMessage3 = await client3.GetAsync("http://localhost:5125/api/DashboardWidgets/AppUserCount");

            var client4 = _httpClientFactory.CreateClient();    
            var responseMessage4 = await client4.GetAsync("http://localhost:5125/api/DashboardWidgets/GetRoomCount");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                ViewBag.StaffCount = jsonData;

                var jsondata2 = await responseMessage2.Content.ReadAsStringAsync(); 
                ViewBag.BookingCount = jsondata2;

                var jsondata3 = await responseMessage3.Content.ReadAsStringAsync();
                ViewBag.AppUserCount = jsondata3;

                var jsondata4 = await responseMessage4.Content.ReadAsStringAsync();
                ViewBag.RoomCount = jsondata4;
            }
            return View();
        }
    }
}
