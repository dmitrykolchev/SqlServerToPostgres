using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CommonSentenceOptionTypes
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }
}
