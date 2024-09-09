using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CommonForumIconTypes
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Url { get; set; }
}
