using AngleSharp.Dom;

namespace HTMLParserCore.Extensions;

// ReSharper disable once InconsistentNaming
public static class IElementExtensions
{
    public static string? GetHref(this IElement element) =>
        element.GetAttribute("href");
}