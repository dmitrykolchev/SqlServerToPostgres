using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CommonEventStatusTypes
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? TextColor { get; set; }

    public string? BkColor { get; set; }
}
