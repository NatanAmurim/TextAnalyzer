namespace TextAnalyzer.Api.Application.CommandsAndQueries.TextAnalyzer.Commands
{
    public record TextAnalyzerCommand
    {
        public string Text { get; set; } = string.Empty;
    }
}
