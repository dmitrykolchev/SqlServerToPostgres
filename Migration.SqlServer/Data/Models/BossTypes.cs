using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class BossTypes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Operations { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? ObjectType { get; set; }

    public string? OperationId { get; set; }
}
