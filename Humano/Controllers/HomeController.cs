using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Humano.Models;
using System.Net.Http;

namespace Humano.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            IEnumerable<Checada> checadas = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://ckassab.xyz:60000/api/");
                //HTTP GET
                var responseTask = client.GetAsync("principal/obtenerchecadas");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Checada>>();
                    readTask.Wait();

                    checadas = readTask.Result;
                }
                else
                {
                    checadas = Enumerable.Empty<Checada>();
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(checadas);
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
