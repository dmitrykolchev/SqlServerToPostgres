// <copyright file="FullNameEntry.cs" company="Division By Zero">
// Copyright (c) 2024 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Finder;

public enum Gender
{
    Unknown,
    Female,
    Male
}

public class FullNameEntry
{
    public string? FullName { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? Surname { get; set; }

    public Gender Gender { get; set; }
}
