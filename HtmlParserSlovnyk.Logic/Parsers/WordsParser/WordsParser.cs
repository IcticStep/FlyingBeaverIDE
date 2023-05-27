using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using HtmlParserCore.API;
using HTMLParserCore.Extensions;

namespace HtmlParserSlovnyk.Logic.Parsers.WordsParser;

public class WordsParser : IParser<WordParsedContent>
{
    private const string AccentuationSpanName = "nagolos";
    public WordParsedContent Parse(IHtmlDocument document)
    {
        var wordElement = document.QuerySelector("h4");
        var contentElement = document.FindClass(AccentuationSpanName)?.Parent;
        var word = wordElement?.TextContent;
        var content = contentElement?.ToHtml();
        
        if (content is null || word is null) 
            return null;
        var cleanedContent = content
            .Replace("<b>", "")
            .Replace("</b>", "")
            .Replace("<span class=\"nagolos\">", "");
        var contentWithAccentuations = cleanedContent.Replace("</span>", "$");

        return new(word, contentWithAccentuations);
    }
}