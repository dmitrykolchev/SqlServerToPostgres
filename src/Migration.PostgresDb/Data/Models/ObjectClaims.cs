using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ObjectClaims
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? SourceType { get; set; }

    public long? SourceId { get; set; }

    public string? SourceName { get; set; }

    public string? SourceCode { get; set; }

    public string? SourceRole { get; set; }

    public string? ObjectType { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public string? ObjectCode { get; set; }

    public string? ElementType { get; set; }

    public long? ElementId { get; set; }

    public string? ElementName { get; set; }

    public string? ElementCode { get; set; }

    public bool? Read { get; set; }

    public bool? Write { get; set; }

    public bool? Delete { get; set; }

    public bool? List { get; set; }

    public bool? Execute { get; set; }

    public long? AccessLevel { get; set; }

    public string? Value { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public bool? IsManual { get; set; }

    public string? DataStr { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
