using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonObjectParamBaseObjectTypes
{
    public string Name { get; set; } = null!;

    public string? Title { get; set; }
}
