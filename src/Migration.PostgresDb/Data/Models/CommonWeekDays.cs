using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonWeekDays
{
    public long Id { get; set; }

    public string? Name { get; set; }
}
