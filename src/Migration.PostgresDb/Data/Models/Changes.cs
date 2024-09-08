using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Changes
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectName { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
