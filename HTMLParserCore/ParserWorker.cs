using HTMLParserCore.API;

namespace HTMLParserCore;

public class ParserWorker<T>
{
    public ParserWorker(IParser<T> parser) => 
        _parser = parser;

    public ParserWorker(IParser<T> parser, IParserSettings settings)
    : this(parser) =>
        _parserSettings = settings;

    private IParser<T> _parser;
    private IParserSettings _parserSettings;
    private HtmlLoader _htmlLoader;

    public IParser<T> Parser
    {
        get => _parser;
        set => _parser = value;
    }

    public IParserSettings ParserSettings
    {
        get => _parserSettings;
        set
        {
            _parserSettings = value;
            _htmlLoader = new HtmlLoader(_parserSettings);
        }
    }

    public void Start()
    {
        
    }
    
    public void Abort()
    {
        
    }
}