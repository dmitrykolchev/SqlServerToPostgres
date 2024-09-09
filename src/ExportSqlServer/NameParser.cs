// <copyright file="NameParser.cs" company="Division By Zero">
// Copyright (c) 2024 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Text;

namespace Finder;

internal class NameParser
{
    private readonly Dictionary<string, string> _names;

    public NameParser(Dictionary<string, string> names)
    {
        _names = names;
    }

    private Dictionary<string, string> Names => _names;

    public string FindAndReplace(string text, out int count, out int replaceCount)
    {
        StringBuilder buffer = new();
        int nameIndex = -1;
        count = 0;
        replaceCount = 0;
        for (int index = 0; index < text.Length; ++index)
        {
            if (char.IsWhiteSpace(text[index]))
            {
                if (nameIndex >= 0)
                {
                    string name = text.Substring(nameIndex, index - nameIndex);
                    if (Names.TryGetValue(name, out string? value))
                    {
                        buffer.Append(value.Substring(0, index - nameIndex));
                        replaceCount++;
                    }
                    else
                    {
                        buffer.Append(name);
                    }
                    nameIndex = -1;
                    count++;
                }
                buffer.Append(text[index]);
            }
            else if (nameIndex < 0)
            {
                nameIndex = index;
            }
        }
        if (nameIndex >= 0)
        {
            string name = text.Substring(nameIndex, text.Length - nameIndex);
            if (Names.TryGetValue(name, out string? value))
            {
                buffer.Append(value.Substring(0, text.Length - nameIndex));
                replaceCount++;
            }
            else
            {
                buffer.Append(name);
            }
            count++;
        }
        return buffer.ToString();
    }
}
