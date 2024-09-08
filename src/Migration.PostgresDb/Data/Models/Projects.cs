using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Projects
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? OrgId { get; set; }

    public long? SubdivisionId { get; set; }

    public long? GroupId { get; set; }

    public long? ContractId { get; set; }

    public long? ProjectTypeId { get; set; }

    public long? SaleContractId { get; set; }

    public string? Status { get; set; }

    public bool? IsModel { get; set; }

    public long? WorkflowId { get; set; }

    public long? PlanLaborCosts { get; set; }

    public long? FactLaborCosts { get; set; }

    public long? PercentComplete { get; set; }

    public bool? TeamSelected { get; set; }

    public DateTime? StartDatePlan { get; set; }

    public DateTime? EndDatePlan { get; set; }

    public DateTime? StartDateFact { get; set; }

    public DateTime? EndDateFact { get; set; }

    public bool? AllowAssessment { get; set; }

    public string? JoinMode { get; set; }

    public long? ResourceTypeId { get; set; }

    public bool? AllParticipantViewTask { get; set; }

    public bool? AllowAssigningTasksToAll { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public List<long>? RoleId { get; set; }
}
