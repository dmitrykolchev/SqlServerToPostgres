using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Contests
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public bool? IsOpen { get; set; }

    public string? StatusId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? EstimationId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
