// <copyright file="NameParser.cs" company="Division By Zero">
// Copyright (c) 2024 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Text;

namespace SqlServerToPostgres;

public class NameParser
{
    public NameParser(Dictionary<string, string> substitutions)
    {
        Substitutions = substitutions;
    }

    private Dictionary<string, string> Substitutions { get; }

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
                    if (Substitutions.TryGetValue(name, out string? value))
                    {
                        buffer.Append(value /* .Truncate(index - nameIndex) */);
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
            if (Substitutions.TryGetValue(name, out string? value))
            {
                buffer.Append(value /* .Truncate(text.Length - nameIndex) */);
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
