using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Tasks
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? TaskTypeId { get; set; }

    public long? ParentTaskId { get; set; }

    public long? TranslatedTaskId { get; set; }

    public string? TranslatedTargetType { get; set; }

    public long? TranslatedTargetId { get; set; }

    public long? AssignerId { get; set; }

    public string? ExecutorType { get; set; }

    public long? ExecutorId { get; set; }

    public string? Status { get; set; }

    public string? CustomStateId { get; set; }

    public string? Plan { get; set; }

    public string? Fact { get; set; }

    public double? PlanValue { get; set; }

    public double? FactValue { get; set; }

    public double? Value { get; set; }

    public double? ReadinessPercent { get; set; }

    public long? Priority { get; set; }

    public string? SourceObjectType { get; set; }

    public long? SourceObjectId { get; set; }

    public long? PayStageId { get; set; }

    public string? TargetObjectType { get; set; }

    public long? TargetObjectId { get; set; }

    public string? FactObjectType { get; set; }

    public long? FactObjectId { get; set; }

    public List<long>? ExpertId { get; set; }

    public DateTime? DatePlan { get; set; }

    public DateTime? DateFact { get; set; }

    public DateTime? StartDatePlan { get; set; }

    public DateTime? EndDatePlan { get; set; }

    public long? PlanBudgetPeriodId { get; set; }

    public long? FactBudgetPeriodId { get; set; }

    public long? PlanLaborCosts { get; set; }

    public long? FactLaborCosts { get; set; }

    public List<long>? RoleId { get; set; }

    public string? Desc { get; set; }

    public string? Comment { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public long? WorkflowId { get; set; }

    public string? WorkflowState { get; set; }

    public string? WorkflowStateName { get; set; }

    public List<long>? WorkflowPersonId { get; set; }

    public string? WorkflowMatchingType { get; set; }

    public long? ConversationId { get; set; }

    public List<long>? PreparationId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
