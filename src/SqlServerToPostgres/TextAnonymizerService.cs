using Microsoft.Extensions.Options;
using System.Text.Json;

namespace SqlServerToPostgres;

public class TextAnonymizerService : IConverter
{
    private static readonly object _sync = new();
    private NameParser? _nameParser;

    public TextAnonymizerService(IOptions<ApplicationOptions> options)
    {
        ApplicationOptions = options.Value;
    }

    private ApplicationOptions ApplicationOptions { get; }

    private AnonymizerServiceOptions Options => ApplicationOptions.Anonymizer!;

    public NameParser NameParser
    {
        get
        {
            if (_nameParser is null)
            {
                lock (_sync)
                {
                    if (_nameParser is null)
                    {
                        using FileStream file = File.OpenRead(Options.SubstitutionsFileName);
                        List<KeyValuePair<string, string>> list
                            = JsonSerializer.Deserialize<List<KeyValuePair<string, string>>>(file)
                                ?? throw new InvalidOperationException($"cannot load data from \"{Options.SubstitutionsFileName}\"");
                        Dictionary<string, string> substitutions
                            = new(list, StringComparer.CurrentCultureIgnoreCase);
                        _nameParser = new NameParser(substitutions);
                    }
                }
            }
            return _nameParser;
        }
    }

    public object? Convert(object? value)
    {
        if (value is null)
        {
            return null;
        }
        string text = (string)value;
        string result = NameParser.FindAndReplace(text, out int count, out int replaceCount);
        if (count <= 3 && count == replaceCount)
        {
            return result;
        }
        return text;
    }
}
