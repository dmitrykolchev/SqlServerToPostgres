using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CommonWebTemplateTypes
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? Url { get; set; }

    public string? Mode { get; set; }

    public string? Wvars { get; set; }

    public string? WvarsSelector { get; set; }
}
