using Microsoft.AspNetCore.Mvc;
using MossadMVC.Models;
using System.Diagnostics;
using Newtonsoft.Json;

namespace MossadMVC.Controllers
{
    public class MissionController : Controller
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly ILogger<MissionController> _logger;

        public MissionController(ILogger<MissionController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public async Task<ActionResult<object>> GetAllMissions()
        {
            var path = await this._httpClient.GetStringAsync("http://localhost:5123/mission");
            var jsonAttack = JsonConvert.DeserializeObject<List<Mission>>(path);
            return View(jsonAttack);
        }


        public async Task<IActionResult> MissionDetails()
        {
            var resolt = await this._httpClient.GetFromJsonAsync<MissionDetails>("http://localhost:5123/mission");
            return View(resolt);
        }




        public IActionResult Privacy()
        {
            return View();
        }
    }
}
