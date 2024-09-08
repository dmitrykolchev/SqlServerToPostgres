using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonServerSettings
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? UserName { get; set; }

    public string? Type { get; set; }

    public string? PassiveInModes { get; set; }

    public string? DefaultValue { get; set; }
}
