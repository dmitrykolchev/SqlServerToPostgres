using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class KpiPlans
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? KpiId { get; set; }

    public long? BudgetPeriodId { get; set; }

    public long? ResponsibleId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Threshold { get; set; }

    public string? ThresholdText { get; set; }

    public double? ThresholdValue { get; set; }

    public string? Challenge { get; set; }

    public string? ChallengeText { get; set; }

    public double? ChallengeValue { get; set; }

    public string? Plan { get; set; }

    public string? PlanText { get; set; }

    public double? PlanValue { get; set; }

    public string? ObjectCatalog { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public List<long>? ExpertId { get; set; }

    public long? WorkflowId { get; set; }

    public string? WorkflowState { get; set; }

    public string? WorkflowStateName { get; set; }

    public List<long>? WorkflowPersonId { get; set; }

    public string? WorkflowMatchingType { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
