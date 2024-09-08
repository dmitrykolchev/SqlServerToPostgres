using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class PayStages
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? OrgId { get; set; }

    public long? ClientOrgId { get; set; }

    public long? SaleContractId { get; set; }

    public long? AgentContractId { get; set; }

    public bool? IsAgentSaleContract { get; set; }

    public long? AgentOrgId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public bool? IsPrepayment { get; set; }

    public string? CostType { get; set; }

    public double? MinCost { get; set; }

    public double? MaxCost { get; set; }

    public double? FactCost { get; set; }

    public string? TypeId { get; set; }

    public string? ClosingMethod { get; set; }

    public long? CostCenterId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public bool? IsAutoclosing { get; set; }

    public long? AutoclosingPeriod { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
