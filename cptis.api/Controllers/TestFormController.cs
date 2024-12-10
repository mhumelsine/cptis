using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace cptis.api.Controllers
{
    [Route("[controller]")]
    [Authorize]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class TestFormController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly ILogger logger;

        public TestFormController(IConfiguration configuration, ILogger logger)
        {
            this.configuration = configuration;
            this.logger = logger;
        }

        [Route("test")]
        [HttpGet]
        public IActionResult GetTest()
        {
            logger.Info("GET FORM called");
            return Ok(new TestCommand{
            Email = "test@test.com",
            Name = "Robert Test",
            TermsAccepted = false,
            SelectedOption = "Option 2"
            
            });
        }

        [Route("test")]
        [Consumes("multipart/form-data")]
        [HttpPost]
        public IActionResult SetTest([FromForm] TestCommand command)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return CreatedAtAction("GetTest", new { command });
        }

        [Route("test")]
        [HttpPut]
        public IActionResult UpdateTest([FromForm] TestCommand command)
        {
            return Ok(new { command });

        }


        public class TestCommand
        {
            [Required]
            public string Name { get; set; }
            public string Email { get; set; }
            public bool TermsAccepted { get; set; }
            public string SelectedOption { get; set; }
        }

    }
}
