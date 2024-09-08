using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonAllOptionTypes
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? Title { get; set; }

    public string? Caption { get; set; }
}
