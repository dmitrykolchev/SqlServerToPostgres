using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class FactPayments
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? OrgId { get; set; }

    public long? ClientOrgId { get; set; }

    public long? AgentOrgId { get; set; }

    public string? ClientLegal { get; set; }

    public string? ProviderLegal { get; set; }

    public string? AgentLegal { get; set; }

    public string? ClientLegalName { get; set; }

    public string? ProviderLegalName { get; set; }

    public string? AgentLegalName { get; set; }

    public string? CostCurrencyTypeId { get; set; }

    public double? CostValue { get; set; }

    public DateTime? Date { get; set; }

    public long? ExpenseId { get; set; }

    public string? Comment { get; set; }

    public DateTime? ModificationDate { get; set; }
}
