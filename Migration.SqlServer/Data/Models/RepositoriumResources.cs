using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class RepositoriumResources
{
    public long Id { get; set; }

    public long? RepositoriumId { get; set; }

    public string? RepositoriumName { get; set; }

    public long? ResourceId { get; set; }
}
