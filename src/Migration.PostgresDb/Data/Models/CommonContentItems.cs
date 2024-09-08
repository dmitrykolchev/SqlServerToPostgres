using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonContentItems
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? HtmlPage { get; set; }

    public string? AccessBlock { get; set; }
}
