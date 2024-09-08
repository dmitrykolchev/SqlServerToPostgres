using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonClObjectGroups
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }
}
