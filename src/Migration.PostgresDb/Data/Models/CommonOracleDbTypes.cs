using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonOracleDbTypes
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }
}
