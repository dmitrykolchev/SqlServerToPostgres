using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class TaggedObjects
{
    public long Id { get; set; }

    public string? Catalog { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public DateTime? DocCreateDate { get; set; }

    public bool? RequireAcknowledgement { get; set; }

    public long? TagId { get; set; }

    public string? TagName { get; set; }
}
