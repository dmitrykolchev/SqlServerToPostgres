// <copyright file="ApplicationOptions.cs" company="Division By Zero">
// Copyright (c) 2024 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Finder;

public class TableFieldPair
{
    public string TableName { get; set; } = null!;
    public string FieldName { get; set; } = null!;
}

public class ApplicationOptions
{
    public string ConnectionString { get; set; } = null!;
    public FullNameOrder FullNameOrder { get; set; }
    public TableFieldPair[] FullNames { get; set; } = null!;
    public int BatchSize { get; set; } = 1000;
    public string NamesFileName { get; set; } = "fullnames.json";
    public string SubstitutionsFileName { get; set; } = "substitutions.json";
    public int CommandTimeout { get; set; } = 30;
    public int MaxRecordLoad { get; set; } = int.MaxValue;
}
