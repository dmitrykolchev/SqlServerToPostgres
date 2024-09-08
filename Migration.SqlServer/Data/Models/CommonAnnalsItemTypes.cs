using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CommonAnnalsItemTypes
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? DataId { get; set; }

    public string? ItemId { get; set; }
}
