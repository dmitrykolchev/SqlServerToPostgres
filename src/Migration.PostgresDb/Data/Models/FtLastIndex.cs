using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class FtLastIndex
{
    public string Form { get; set; } = null!;

    public DateTime? LastFtIndexDate { get; set; }
}
