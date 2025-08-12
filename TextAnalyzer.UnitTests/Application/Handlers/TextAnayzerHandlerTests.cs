using Moq;
using TextAnalyzer.Api.Application.Handlers;
using TextAnalyzer.Api.Application.Handlers.Interfaces;

namespace TextAnalyzer.UnitTests.Application.Handlers
{
    public class TextAnayzerHandlerTests
    {

        private Mock<IWordExtractorHandler> _wordExtractorHandler;
        private TextAnayzerHandler _textAnayzerHandler;

        [SetUp]
        public void Setup()
        {
            _wordExtractorHandler = new Mock<IWordExtractorHandler>();
            _textAnayzerHandler = new TextAnayzerHandler(_wordExtractorHandler.Object);
        }

        [Test]
        public void AnalyzeText_ShouldReturnFormattedText()
        {
            var mockDictionary = new Dictionary<string, int>
            {
                {"hello", 1},
                {"word", 2}
            };
            _wordExtractorHandler.Setup(x => x.ExtractWordsFromText(It.IsAny<string>())).Returns(mockDictionary);
            
            var analysedText  = _textAnayzerHandler.AnalyzeText("someText");

            Assert.That(analysedText, Is.SameAs("Total"));
                      
        }
    }
}
