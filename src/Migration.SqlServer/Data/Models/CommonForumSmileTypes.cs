using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CommonForumSmileTypes
{
    public string Id { get; set; } = null!;

    public string? Url { get; set; }
}
