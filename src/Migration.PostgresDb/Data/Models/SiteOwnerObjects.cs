using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class SiteOwnerObjects
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? SiteId { get; set; }

    public long? ObjectId { get; set; }

    public string? CatalogName { get; set; }
}
