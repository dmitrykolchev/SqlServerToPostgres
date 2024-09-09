using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CommonCollectStates
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }
}
