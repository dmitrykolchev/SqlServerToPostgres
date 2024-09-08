using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CareerTrees
{
    public long Id { get; set; }

    public string? CurrentPositionName { get; set; }

    public string? PositionName { get; set; }

    public string? PersonFullname { get; set; }

    public string? PositionCollaboratorFullname { get; set; }
}
