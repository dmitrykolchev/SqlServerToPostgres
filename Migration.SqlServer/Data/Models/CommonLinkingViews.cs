using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CommonLinkingViews
{
    public string Name { get; set; } = null!;

    public string? DispName { get; set; }

    public string? Title { get; set; }
}
