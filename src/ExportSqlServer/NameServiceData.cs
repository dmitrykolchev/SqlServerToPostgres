// <copyright file="NameServiceData.cs" company="Division By Zero">
// Copyright (c) 2024 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Finder;

public class NameServiceData
{
    private readonly HashSet<int> _used = new();

    public List<FullNameEntry>? Entries { get; set; }

    public List<string>? FirstNames { get; set; }

    public List<string>? MiddleNames { get; set; }

    public List<string>? Surnames { get; set; }

    public Dictionary<string, string> GetAllNames()
    {
        Dictionary<string, string> result = new(StringComparer.InvariantCultureIgnoreCase);
        foreach (var item in FirstNames!)
        {
            if (!result.ContainsKey(item))
            {
                int id = GetRandomId();
                result.Add(item, $"{++id:0000000000}");
            }
        }
        foreach (var item in MiddleNames!)
        {
            if (!result.ContainsKey(item))
            {
                int id = GetRandomId();
                result.Add(item, $"{++id:0000000000}");
            }
        }
        foreach (var item in Surnames!)
        {
            if (!result.ContainsKey(item))
            {
                int id = GetRandomId();
                result.Add(item, $"{++id:0000000000}");
            }
        }
        return result;
    }

    private int GetRandomId()
    {
        for (; ; )
        {
            int value = Random.Shared.Next(1, int.MaxValue);
            if (_used.Add(value))
            {
                return value;
            }
        }
    }
}
