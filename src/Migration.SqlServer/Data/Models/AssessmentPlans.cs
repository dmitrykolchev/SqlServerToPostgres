using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class AssessmentPlans
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? AssessmentAppraiseId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonPositionName { get; set; }

    public long? ExpertPersonId { get; set; }

    public string? ExpertPersonFullname { get; set; }

    public string? ExpertPersonPositionName { get; set; }

    public string? CustomExperts { get; set; }

    public long? DepartmentId { get; set; }

    public string? DepartmentName { get; set; }

    public bool? FlagAppraiseDepartment { get; set; }

    public bool? IsDone { get; set; }

    public string? AssessmentAppraiseType { get; set; }

    public string? Status { get; set; }

    public long? BossId { get; set; }

    public double? IntegralMark { get; set; }

    public long? WorkflowId { get; set; }

    public string? WorkflowState { get; set; }

    public bool? IsWorkflowInit { get; set; }

    public long? Index { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
