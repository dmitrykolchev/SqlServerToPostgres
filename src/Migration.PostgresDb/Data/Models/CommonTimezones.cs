using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonTimezones
{
    public long Id { get; set; }

    public long? Direction { get; set; }

    public double? Tm { get; set; }

    public string? Name { get; set; }
}
