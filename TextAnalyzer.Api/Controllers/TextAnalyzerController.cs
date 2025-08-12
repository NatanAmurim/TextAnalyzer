using Microsoft.AspNetCore.Mvc;

namespace TextAnalyzer.Api.Controllers
{
    [ApiController]
    [Route("api/text-analyzer")]
    public class TextAnalyzerController : ControllerBase
    {        
        public TextAnalyzerController()
        {
            
        }

        [HttpPost()]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
