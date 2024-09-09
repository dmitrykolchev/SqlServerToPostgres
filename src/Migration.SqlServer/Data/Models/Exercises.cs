using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Exercises
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? RoleId { get; set; }
}
