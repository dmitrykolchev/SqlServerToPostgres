using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Dimensions
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }
}
