using TextAnalyzer.Api.Application.Handlers.Interfaces;

namespace TextAnalyzer.Api.Application.Handlers
{
    public class WordExtractorHandler : IWordExtractorHandler
    {
        public Dictionary<string, int> ExtractWordsFromText(string text)
        {
            var words = text.Split(' ');

            var wordDictionary = new Dictionary<string, int>();

            foreach (var word in words)
            {
                var key = word.ToLower();

                if (wordDictionary.ContainsKey(key))
                    wordDictionary[key]++;
                else
                    wordDictionary.Add(key, 1);
            }

            return wordDictionary;
        }
    }
}
