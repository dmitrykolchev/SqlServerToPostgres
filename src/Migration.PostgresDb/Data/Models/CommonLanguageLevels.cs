using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonLanguageLevels
{
    public long Id { get; set; }

    public string? Name { get; set; }
}
