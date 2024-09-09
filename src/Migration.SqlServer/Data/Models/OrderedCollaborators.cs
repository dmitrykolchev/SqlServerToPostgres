using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class OrderedCollaborators
{
    public string? PositionName { get; set; }

    public string? CommonDivisionName { get; set; }

    public long? CommonDivisionId { get; set; }

    public string? CommonPositionName { get; set; }

    public long? CommonPositionId { get; set; }
}
