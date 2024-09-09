using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CommonWeekDayTypes
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? ShortName { get; set; }

    public long? Index { get; set; }
}
