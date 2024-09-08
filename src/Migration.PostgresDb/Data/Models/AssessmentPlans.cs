using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class AssessmentPlans
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? AssessmentAppraiseId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonPositionName { get; set; }

    public long? PersonPositionId { get; set; }

    public long? PersonPositionParentId { get; set; }

    public long? ExpertPersonId { get; set; }

    public string? ExpertPersonFullname { get; set; }

    public string? ExpertPersonPositionName { get; set; }

    public long? ExpertPersonPositionId { get; set; }

    public long? ExpertPersonPositionParentId { get; set; }

    public string? CustomExperts { get; set; }

    public List<long>? CustomExpertsArray { get; set; }

    public bool? IsCustomExperts { get; set; }

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

    public string? WorkflowStateName { get; set; }

    public DateTime? WorkflowStateLastDate { get; set; }

    public bool? IsWorkflowInit { get; set; }

    public bool? FlagIsProcessed { get; set; }

    public long? WorkflowPersonId { get; set; }

    public DateTime? WorkflowEndDate { get; set; }

    public long? Index { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public long? BudgetPeriodId { get; set; }

    public DateTime? PeriodStart { get; set; }

    public DateTime? PeriodEnd { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
