using TextAnalyzer.Api.Application.Handlers;

namespace TextAnalyzer.UnitTests.Application.Handlers
{
    public class WordExtractorHandlerTests
    {
        private WordExtractorHandler _wordExtractorHandler;

        [SetUp]
        public void Setup() 
        {
            _wordExtractorHandler = new WordExtractorHandler();
        }

        [Test]
        public void GetWordDictionary_ShouldReturnDictionaryWithWordsInTextAndCouter()
        {
            var text = "Hello HELLO Word WOrd";
            Dictionary<string, int> result = _wordExtractorHandler.ExtractWordsFromText(text);

            Assert.That(result.ContainsKey("hello"), Is.True);
            Assert.That(result.ContainsKey("word"), Is.True);

            Assert.That(result["hello"], Is.EqualTo(2), "A palavra hello deve aparecer 2 vezes no teste.");
            Assert.That(result["word"], Is.EqualTo(2), "A palavra word deve aparecer 2 vezes no teste.");
        }
    }
}
