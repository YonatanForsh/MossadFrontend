using Microsoft.AspNetCore.Mvc;
using MossadMVC.Models;
using Newtonsoft.Json;

namespace MossadMVC.Controllers
{
    public class AgentController : Controller
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly ILogger<AgentController> _logger;

        public AgentController(ILogger<AgentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<object>> GetAllAgents()
        {
            var path = await this._httpClient.GetStringAsync("http://localhost:5123/agents");
            var jsonAttack = JsonConvert.DeserializeObject<List<Agent>>(path);
            return View(jsonAttack);
        }
    }
}
