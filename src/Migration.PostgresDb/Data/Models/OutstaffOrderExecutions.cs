using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class OutstaffOrderExecutions
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? CollaboratorFullname { get; set; }

    public long? PositionCommonId { get; set; }

    public string? PositionCommonName { get; set; }

    public long? SubdivisionId { get; set; }

    public string? SubdivisionName { get; set; }

    public long? BudgetPeriodId { get; set; }

    public long? OutstaffContractId { get; set; }

    public string? OutstaffContractName { get; set; }

    public DateTime? FormedDate { get; set; }

    public DateTime? PaidDate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public bool? EnableAnonymousAccess { get; set; }

    public long? AccessLevel { get; set; }

    public string? AccessRoles { get; set; }

    public string? AccessGroups { get; set; }

    public long? AccessOrgId { get; set; }

    public long? AccessSiteId { get; set; }

    public long? AccessHostId { get; set; }

    public long? WebModeId { get; set; }

    public string? Operator { get; set; }

    public string? Conditions { get; set; }

    public string? ConditionsQual { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
