using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Licenses
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public long? UsersNum { get; set; }
}
