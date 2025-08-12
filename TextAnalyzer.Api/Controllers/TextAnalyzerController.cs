using Microsoft.AspNetCore.Mvc;
using TextAnalyzer.Api.Application.CommandsAndQueries.TextAnalyzer.Commands;
using TextAnalyzer.Api.Application.Common;
using TextAnalyzer.Api.Application.Handlers;

namespace TextAnalyzer.Api.Controllers
{
    [ApiController]
    [Route("api/text-analyzer")]
    public class TextAnalyzerController(TextAnayzerHandler textAnayzerService) : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] TextAnalyzerCommand textAnalyzerCommand)
        {

            if (string.IsNullOrEmpty(textAnalyzerCommand.Text))
                return BadRequest(new ErrorResult("O valor de text não pode ser nulo."));

            var result = textAnayzerService.AnalyzeText(textAnalyzerCommand.Text);

            if (!result.Success)
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResult(result.Message!));

            return Ok(new { result.WordCount, result.Occurrences });
        }
    }
}
