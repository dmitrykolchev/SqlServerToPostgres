using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CommonPollTypes
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public bool? Multiple { get; set; }

    public bool? IsTable { get; set; }
}
