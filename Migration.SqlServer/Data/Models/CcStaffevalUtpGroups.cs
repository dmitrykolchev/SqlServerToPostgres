using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcStaffevalUtpGroups
{
    public long Id { get; set; }

    public long? ParentId { get; set; }

    public string? Name { get; set; }

    public long? Plan { get; set; }

    public long? Fact { get; set; }

    public long? PlanI { get; set; }

    public long? FactI { get; set; }

    public long? Station { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
