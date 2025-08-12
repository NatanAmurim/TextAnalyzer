using TextAnalyzer.Api.Application.Handlers.Interfaces;

namespace TextAnalyzer.Api.Application.Handlers
{
    public class TextAnayzerHandler(IWordExtractorHandler wordExtractorService)
    {        
        public string AnalyzeText(string text)
        {
            var wordDictionary = wordExtractorService.ExtractWordsFromText(text);
            var message = FormatMessage(wordDictionary);

            return message;
        }

        private static string FormatMessage(Dictionary<string, int> wordDictionary)
        {
            var message = $"Total de palavras: {wordDictionary.Count}\n\n";

            foreach (var word in wordDictionary)
                message += $"{word.Key}: {word.Value}\n";

            return message;
        }
    }
}
