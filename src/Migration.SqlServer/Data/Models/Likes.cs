using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Likes
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectName { get; set; }

    public double? Weight { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
