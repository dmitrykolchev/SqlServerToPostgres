using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonExpertEvalTypes
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }
}
