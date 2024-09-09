// <copyright file="XmlAnonymizerService.cs" company="Division By Zero">
// Copyright (c) 2024 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Text.Json;
using System.Xml;
using System.Xml.XPath;
using Microsoft.Extensions.Options;

namespace SqlServerToPostgres;

public class XmlAnonymizerService : IConverter
{
    private static readonly object _sync = new();
    private NameParser? _nameParser;

    public XmlAnonymizerService(IOptions<ApplicationOptions> options)
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
        XmlDocument document = new();
        document.LoadXml((string)value);
        XPathNavigator? navigator = document.CreateNavigator()!;
        XPathNodeIterator nodes = navigator.Select(Options.NamesXPath /*"//*[contains(name(), 'name')]" */);
        foreach (XPathNavigator node in nodes)
        {
            if (node.MoveToChild(XPathNodeType.Text))
            {
                string text = node.Value;
                string result = NameParser.FindAndReplace(text, out int count, out int replaceCount);
                if (count <= 3 && count == replaceCount)
                {
                    node.SetValue(result);
                }
            }
        }
        if (Options.MaskXPath is not null)
        {
            nodes = navigator.Select(Options.MaskXPath);
            foreach (XPathNavigator node in nodes)
            {
                if (node.MoveToChild(XPathNodeType.Text))
                {
                    string text = node.Value;
                    if (!string.IsNullOrEmpty(text))
                    {
                        node.SetValue(new string('*', text.Length));
                    }
                }
            }
        }
        using StringWriter writer = new();
        using XmlWriter xmlWriter = XmlWriter.Create(writer, new XmlWriterSettings
        {
            OmitXmlDeclaration = true,
            Indent = false
        });
        document.Save(xmlWriter);
        return writer.GetStringBuilder().ToString();
    }
}
