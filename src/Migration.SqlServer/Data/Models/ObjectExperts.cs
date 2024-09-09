using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class ObjectExperts
{
    public long Id { get; set; }

    public string? ObjectType { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? Type { get; set; }
}
