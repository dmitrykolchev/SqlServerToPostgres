using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonOperationTypes
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public long? Type { get; set; }

    public string? OperationCatalog { get; set; }
}
