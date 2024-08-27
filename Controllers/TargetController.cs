using Microsoft.AspNetCore.Mvc;
using MossadMVC.Models;
using Newtonsoft.Json;


namespace MossadMVC.Controllers
{
    public class TargetController : Controller
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly ILogger<TargetController> _logger;

        public TargetController(ILogger<TargetController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<object>> GetAllTargets()
        {
            //var path = await this._httpClient.GetFromJsonAsync<Target[]>("http://localhost:5123/target");
            
            var path = await this._httpClient.GetStringAsync("http://localhost:5123/target");
            var jsonAttack = JsonConvert.DeserializeObject<List<Target>>(path);
            return View(jsonAttack);
        }
    }
}
