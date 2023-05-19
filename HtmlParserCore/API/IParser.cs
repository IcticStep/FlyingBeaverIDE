using AngleSharp.Html.Dom;

namespace HtmlParserCore.API;

public interface IParser<T>
{
    public T Parse(IHtmlDocument document);
}