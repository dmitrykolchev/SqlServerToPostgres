using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonVideoFormats
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public long? Width { get; set; }

    public long? Height { get; set; }
}
