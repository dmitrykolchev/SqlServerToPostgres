using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonMonths
{
    public string Id { get; set; } = null!;

    public long? Number { get; set; }

    public string? Name { get; set; }

    public string? NameGenitive { get; set; }

    public long? Days { get; set; }

    public long? Quarter { get; set; }
}
