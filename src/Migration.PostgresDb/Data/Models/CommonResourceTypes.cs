using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonResourceTypes
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? Ext { get; set; }

    public bool? IsMedia { get; set; }

    public bool? UseCache { get; set; }
}
