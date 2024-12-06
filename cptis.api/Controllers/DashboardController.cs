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
        private readonly ILogger logger;

        public DashboardController(IConfiguration configuration, ILogger logger)
        {
            this.configuration = configuration;
            this.logger = logger;
        }

        [Route("test")]
        [HttpGet]
        public IActionResult GetTest()
        {
            logger.Info("GetTest called");
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
