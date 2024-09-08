using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Budgets
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public bool? IsApproved { get; set; }

    public long? TypeId { get; set; }

    public string? State { get; set; }

    public double? Cost { get; set; }

    public double? CostNds { get; set; }

    public string? Currency { get; set; }

    public long? CostCenterId { get; set; }

    public long? BudgetPeriodId { get; set; }

    public long? ExpenseItemId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
