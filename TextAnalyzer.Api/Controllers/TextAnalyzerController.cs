using Microsoft.AspNetCore.Mvc;
using TextAnalyzer.Api.Application.CommandsAndQueries.TextAnalyzer.Commands;
using TextAnalyzer.Api.Application.Handlers;

namespace TextAnalyzer.Api.Controllers
{
    [ApiController]
    [Route("api/text-analyzer")]
    public class TextAnalyzerController(TextAnayzerHandler textAnayzerService) : ControllerBase
    {        
        [HttpPost()]
        public IActionResult Post([FromBody] TextAnalyzerCommand textAnalyzerCommand)
        {
            var result = textAnayzerService.AnalyzeText(textAnalyzerCommand.Text);

            return Ok(result);
        }
    }
}
