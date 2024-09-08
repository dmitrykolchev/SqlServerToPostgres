using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonDischargeTypes
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public bool? IsImport { get; set; }

    public string? SourceName { get; set; }
}
