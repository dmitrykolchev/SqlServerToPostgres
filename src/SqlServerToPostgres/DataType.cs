// <copyright file="DataType.cs" company="Division By Zero">
// Copyright (c) 2024 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace SqlServerToPostgres;

public enum DataType
{
    Bool,
    TinyInt,
    SmallInt,
    Int,
    BigInt,
    Real,
    Float,
    Decimal,
    Date,
    DateTime,
    Time,
    VarChar,
    Uuid,
    Text,
    DoublePrecision,
    ByteArray,
    Array,
    Xml
}

public class DataTypeConverter
{
    public static Type GetClrType(DataType dataType)
    {
        switch (dataType)
        {
            case DataType.BigInt:
                return typeof(long);
            case DataType.TinyInt:
                return typeof(byte);
            case DataType.Bool:
                return typeof(bool);
            case DataType.Date:
                return typeof(DateTime);
            case DataType.DateTime:
                return typeof(DateTime);
            case DataType.Time:
                return typeof(DateTime);
            case DataType.Decimal:
                return typeof(decimal);
            case DataType.Float:
                return typeof(double);
            case DataType.Int:
                return typeof(int);
            case DataType.Real:
                return typeof(float);
            case DataType.SmallInt:
                return typeof(short);
            case DataType.Text:
                return typeof(string);
            case DataType.Uuid:
                return typeof(Guid);
            case DataType.VarChar:
                return typeof(string);
            case DataType.DoublePrecision:
                return typeof(double);
            case DataType.ByteArray:
                return typeof(byte[]);
            case DataType.Xml:
                return typeof(string);
            default:
                throw new InvalidOperationException();
        }
    }

    public static DataType GetSqlColumnDataType(string dataType, int? maxLength)
    {
        switch (dataType.ToLower())
        {
            case "bigint":
                return DataType.BigInt;
            case "bit":
                return DataType.Bool;
            case "char":
                return DataType.VarChar;
            case "date":
                return DataType.Date;
            case "datetime":
            case "datetime2":
                return DataType.DateTime;
            case "decimal":
                return DataType.Decimal;
            case "int":
                return DataType.Int;
            case "smallint":
                return DataType.SmallInt;
            case "tinyint":
                return DataType.TinyInt;
            case "uniqueidentifier":
                return DataType.Uuid;
            case "nvarchar":
            case "varchar":
                if (maxLength == -1)
                {
                    return DataType.Text;
                }
                return DataType.VarChar;
            case "time":
                return DataType.Time;
            case "float":
                return DataType.DoublePrecision;
            case "varbinary":
                return DataType.ByteArray;
            case "timestamp":
                return DataType.ByteArray;
            case "xml":
                return DataType.Xml;
            case "text":
            case "ntext":
                return DataType.Text;
            default:
                throw new InvalidOperationException($"unsupported data type: {dataType}");
        }

    }

    public static DataType GetPostgresColumnDataType(string dataType, int? maxLength)
    {
        switch (dataType.ToLower())
        {
            case "bigint":
                return DataType.BigInt;
            case "boolean":
                return DataType.Bool;
            case "character varying":
                return DataType.VarChar;
            case "date":
                return DataType.Date;
            case "integer":
                return DataType.Int;
            case "numeric":
                return DataType.Decimal;
            case "smallint":
                return DataType.SmallInt;
            case "text":
                return DataType.Text;
            case "timestamp with time zone":
            case "timestamp without time zone":
                return DataType.DateTime;
            case "time without time zone":
                return DataType.Time;
            case "uuid":
                return DataType.Uuid;
            case "double precision":
                return DataType.DoublePrecision;
            case "bytea":
                return DataType.ByteArray;
            case "xml":
                return DataType.Xml;
            case "array":
                return DataType.Array;
            default:
                throw new InvalidOperationException($"unsupported data type: {dataType}");
        }
    }

}
