namespace TextAnalyzer.Api.Application.Handlers.Interfaces
{
    public interface IWordExtractorHandler
    {
        public Dictionary<string, int> ExtractWordsFromText(string text);
    }
}
