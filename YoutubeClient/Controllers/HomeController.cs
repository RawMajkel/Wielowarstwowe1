using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using YoutubeClient.Models;

namespace YoutubeClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly string ApiKey = "AIzaSyAofLH2rh3ZLP9-Xd40Kbvizp4gLzljVc4";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Videos([FromQuery] string search)
        {
            var url = String.IsNullOrEmpty(search) ? $"https://www.googleapis.com/youtube/v3/videos?part=snippet&chart=mostPopular&key=AIzaSyDKMM-U6gMdJM20D9KAFIrAlhdUchkBBI" : $"https://www.googleapis.com/youtube/v3/search?part=snippet&q={search}&key={ApiKey}";
            _logger.LogInformation($"url: {url}");

            var client = new HttpClient();
            var response = await client.GetAsync(url);

            if(response.IsSuccessStatusCode)
            {
                var ytStringResponse = await response.Content.ReadAsStringAsync();
                var ytResponse = JsonConvert.DeserializeObject<YoutubeResponse>(ytStringResponse);

                var ytVideos = ytResponse.items.Select(n => new Video
                {
                    Id = n.id,
                    Title = n.snippet.title,
                    Description = n.snippet.description
                });

                return View(ytVideos);
            }

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
