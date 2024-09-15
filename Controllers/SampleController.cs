using Microsoft.AspNetCore.Mvc;

namespace FixedAsset.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "Hello, world!" });
        }
    }
}
