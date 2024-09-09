// <copyright file="ColumnInfo.cs" company="Division By Zero">
// Copyright (c) 2024 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace SqlServerToPostgres;

public class ColumnInfo
{
    public string Name { get; set; } = null!;

    public bool IsNullable { get; set; }

    public DataType DataType { get; set; }

    public string? NativeDataType { get; set; }

    public int? CharacterMaximumLength { get; set; }

    public byte? NumericPrecision { get; set; }

    public int? NumericScale { get; set; }

    public int OrdinalPosition { get; set; }

    public string TableSchema { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public override string ToString()
    {
        if (NativeDataType == null)
        {
            return Name;
        }
        return $"{Name} {DataType} {(IsNullable ? "null" : "not null")}";
    }
}
