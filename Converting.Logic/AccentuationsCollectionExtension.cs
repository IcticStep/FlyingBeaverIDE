using HtmlParserSlovnyk.Domain;

namespace Converting.Logic;

public static class AccentuationsCollectionExtension
{
    public static IEnumerable<WordParsedContent> RemoveDuplicates(
        this IEnumerable<WordParsedContent> collection) =>
        collection
            .GroupBy(x => x.Word)
            .Select(y => y.First());

}