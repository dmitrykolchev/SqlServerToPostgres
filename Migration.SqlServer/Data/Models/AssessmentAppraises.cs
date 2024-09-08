using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class AssessmentAppraises
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public bool? IsModel { get; set; }

    public bool? WebDisplay { get; set; }

    public bool? FlagUsePlan { get; set; }

    public bool? IgnorePresence { get; set; }

    public string? ExternalDisplayOptions { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public long? PersonId { get; set; }

    public long? WorkflowId { get; set; }

    public string? RoleId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public long? Player { get; set; }
}
