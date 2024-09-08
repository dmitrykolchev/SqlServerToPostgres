using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CommonAccessBlockTypes
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? ObjectsAccess { get; set; }

    public string? IconUrl { get; set; }

    public string? FirstCatalogUrl { get; set; }

    public bool? Disp { get; set; }

    public bool? Sys { get; set; }

    public string? LicenseCatalogs { get; set; }

    public long? ListIndex { get; set; }

    public string? Structure { get; set; }

    public bool? NeverSaved { get; set; }

    public bool? IsDefault { get; set; }
}
