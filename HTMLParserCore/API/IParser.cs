using AngleSharp.Html.Dom;

namespace HTMLParserCore.API;

public interface IParser<T>
{
    public T Parse(IHtmlDocument document);
}