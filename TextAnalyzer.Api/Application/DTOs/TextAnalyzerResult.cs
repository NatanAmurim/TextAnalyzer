namespace TextAnalyzer.Api.Application.DTOs
{
    public record TextAnalysisResult(
        bool Success,
        string? Message = default,
        int? WordCount = default,
        Dictionary<string, int>? Occurrences = default
    );
}
