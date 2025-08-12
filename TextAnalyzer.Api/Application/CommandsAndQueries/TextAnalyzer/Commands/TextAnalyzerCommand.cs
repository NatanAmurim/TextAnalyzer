using System.ComponentModel.DataAnnotations;

namespace TextAnalyzer.Api.Application.CommandsAndQueries.TextAnalyzer.Commands
{
    public record TextAnalyzerCommand(string Text);
}
