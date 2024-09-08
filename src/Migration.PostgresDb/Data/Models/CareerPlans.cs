using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CareerPlans
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public DateTime? StartDate { get; set; }

    public string? Status { get; set; }

    public long? BudgetPeriodId { get; set; }

    public long? TypicalCareerPlanId { get; set; }

    public string? ObjectType { get; set; }

    public long? ObjectId { get; set; }

    public List<long>? RoleId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
