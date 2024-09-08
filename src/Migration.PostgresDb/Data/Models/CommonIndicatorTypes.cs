using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonIndicatorTypes
{
    public long Id { get; set; }

    public string? Name { get; set; }
}
