using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CommonPrintFormTypes
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? ContentType { get; set; }

    public string? Extension { get; set; }
}
