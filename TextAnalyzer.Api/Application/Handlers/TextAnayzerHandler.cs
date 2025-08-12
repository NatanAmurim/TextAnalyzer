using TextAnalyzer.Api.Application.DTOs;
using TextAnalyzer.Api.Application.Handlers.Interfaces;

namespace TextAnalyzer.Api.Application.Handlers
{
    public class TextAnayzerHandler(IWordExtractorHandler wordExtractorService)
    {
        public TextAnalysisResult AnalyzeText(string text)
        {
            try
            {
                var wordDictionary = wordExtractorService.ExtractWordsFromText(text);                
                return new TextAnalysisResult(true, WordCount: wordDictionary.Count, Occurrences: wordDictionary);
            }
            catch (Exception ex)
            {
                return new TextAnalysisResult(false, $"Houve um erro ao realizar a tratativa.\nErro: {ex.Message}");                
            }
        }
    }
}
