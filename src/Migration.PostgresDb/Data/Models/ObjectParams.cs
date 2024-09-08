using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ObjectParams
{
    public long Id { get; set; }

    public bool? IsEnabled { get; set; }

    public DateTime? StartDate { get; set; }

    public string? ObjectType { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public string? SecObjectCode { get; set; }

    public string? BaseObjectType { get; set; }

    public long? BaseObjectId { get; set; }

    public string? BaseObjectName { get; set; }
}
