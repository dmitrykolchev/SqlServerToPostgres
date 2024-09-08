using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class SubdivisionGroupSubdivisions
{
    public long Id { get; set; }

    public long? SubdivisionGroupId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public bool? IsDynamic { get; set; }

    public long? SubdivisionId { get; set; }

    public string? SubdivisionName { get; set; }
}
