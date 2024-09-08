using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Plugins
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Block { get; set; }

    public string? PluginId { get; set; }

    public long? Version { get; set; }

    public DateTime? ModificationDate { get; set; }
}
