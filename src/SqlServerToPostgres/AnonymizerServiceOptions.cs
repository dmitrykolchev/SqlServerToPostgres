﻿// <copyright file="AnonymizerServiceOptions.cs" company="Division By Zero">
// Copyright (c) 2024 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace SqlServerToPostgres;

public class AnonymizerServiceOptions
{
    public string SubstitutionsFileName { get; set; } = null!;

    public string NamesXPath { get; set; } = null!;

    public string? MaskXPath { get; set; }
}
