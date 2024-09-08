using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CommonCoursePartTypes
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? IcoUrl { get; set; }
}
