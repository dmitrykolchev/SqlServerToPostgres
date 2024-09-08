using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonLinkingViews
{
    public string Name { get; set; } = null!;

    public string? CatalogName { get; set; }

    public string? DispName { get; set; }

    public string? Title { get; set; }

    public string? ViewUrl { get; set; }
}
