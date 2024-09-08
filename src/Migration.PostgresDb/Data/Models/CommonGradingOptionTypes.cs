using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonGradingOptionTypes
{
    public string Id { get; set; } = null!;

    public string? OptionId { get; set; }

    public string? QtiTag { get; set; }
}
