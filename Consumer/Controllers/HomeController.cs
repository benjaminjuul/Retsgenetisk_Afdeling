using Consumer.Models;
using DataClass;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Consumer.Controllers
{


    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {

            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("myendpoint");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();

            var fruits = JsonConvert.DeserializeObject<List<Fruit>>(json);

            return View(fruits);
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