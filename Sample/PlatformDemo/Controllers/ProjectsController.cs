using Microsoft.AspNetCore.Mvc;

namespace PlatformDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Reading all the tickets.");
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok($"Reading ticket#{id}.");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Creating all the tickets.");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("Updating a ticket");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleting ticket #{id}.");
        }
    }
}

