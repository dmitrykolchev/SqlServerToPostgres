// <copyright file="StringExtensions.cs" company="Division By Zero">
// Copyright (c) 2024 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace SqlServerToPostgres;

public static class StringExtensions
{
    public static string Truncate(this string value, int maxLength)
    {
        if (string.IsNullOrEmpty(value))
        {
            return value;
        }
        return value.Length <= maxLength ? value : value[..maxLength];
    }
}
