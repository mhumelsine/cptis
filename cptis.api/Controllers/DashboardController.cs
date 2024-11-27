using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace cptis.api.Controllers
{
    [Route("[controller]")]
    [Authorize]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class DashboardController : Controller
    {
        private readonly IConfiguration configuration;

        public DashboardController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [Route("test")]
        [HttpGet]
        public IActionResult GetTest()
        {
            return Ok(new { test = "test data" });
        }

        [Route("test")]
        [HttpPost]
        public IActionResult SetTest([FromBody] string name)
        {
            return CreatedAtAction("GetTest", new { test = name });
        }

        [Route("test")]
        [HttpPut]
        public IActionResult UpdateTest([FromBody] string name)
        {
            return Ok(new { name });
        }

    }
}
