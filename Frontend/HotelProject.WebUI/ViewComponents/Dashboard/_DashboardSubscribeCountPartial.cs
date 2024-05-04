﻿using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //        var client = new HttpClient();
            //        var request = new HttpRequestMessage
            //        {
            //            Method = HttpMethod.Get,
            //            RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/audi"),
            //            Headers =
            //{
            //    { "X-RapidAPI-Key", "079d4ee644msh6b76d5aebb3514bp1771a5jsn3a7505f5e14e" },
            //    { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
            //},
            //        };
            //        using (var response = await client.SendAsync(request))
            //        {
            //            response.EnsureSuccessStatusCode();
            //            var body = await response.Content.ReadAsStringAsync();
            //            ResultInstagramFollowersDto resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
            //            ViewBag.Followers = resultInstagramFollowersDtos.followers;
            //            ViewBag.Following = resultInstagramFollowersDtos.following;
            //        }

            ViewBag.Followers = 17465;
            ViewBag.Following = 456;

            //        var client2 = new HttpClient();
            //        var request2 = new HttpRequestMessage
            //        {
            //            Method = HttpMethod.Get,
            //            RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=AudiOfficial"),
            //            Headers =
            //{
            //    { "X-RapidAPI-Key", "079d4ee644msh6b76d5aebb3514bp1771a5jsn3a7505f5e14e" },
            //    { "X-RapidAPI-Host", "twitter32.p.rapidapi.com" },
            //},
            //        };
            //        using (var response2 = await client2.SendAsync(request2))
            //        {
            //            response2.EnsureSuccessStatusCode();
            //            var body2 = await response2.Content.ReadAsStringAsync();
            //            ResultTwitterFollowersDto resultTwitterFollowersDto = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
            //            ViewBag.FollowersCount = resultTwitterFollowersDto.data.user_info.followers_count;
            //            ViewBag.FriendsCount = resultTwitterFollowersDto.data.user_info.friends_count;
            //        }


            ViewBag.FollowersCount = 22;
            ViewBag.FriendsCount = 33;

            //        var client3 = new HttpClient();
            //        var request3 = new HttpRequestMessage
            //        {
            //            Method = HttpMethod.Get,
            //            RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fvural-sayan-79326a171%2F&include_skills=false"),
            //            Headers =
            //{
            //    { "X-RapidAPI-Key", "079d4ee644msh6b76d5aebb3514bp1771a5jsn3a7505f5e14e" },
            //    { "X-RapidAPI-Host", "fresh-linkedin-profile-data.p.rapidapi.com" },
            //},
            //        };
            //        using (var response3 = await client3.SendAsync(request3))
            //        {
            //            response3.EnsureSuccessStatusCode();
            //            var body3 = await response3.Content.ReadAsStringAsync();
            //            ResultLinkedinFollowersDto resultLinkedinFollowersDto = JsonConvert.DeserializeObject<ResultLinkedinFollowersDto>(body3);
            //            ViewBag.ConnectionsCount = resultLinkedinFollowersDto.data.connections_count;
            //            ViewBag.FollowersCount = resultLinkedinFollowersDto.data.followers_count;
            //        }

            ViewBag.ConnectionsCount = 11;
            ViewBag.FollowersCount = 12;



            return View();
        }



    }
}
