using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class BonusItems
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? AssessmentAppraiseId { get; set; }

    public long? BudgetPeriodId { get; set; }

    public long? PersonId { get; set; }

    public DateTime? PeriodStart { get; set; }

    public DateTime? PeriodEnd { get; set; }

    public double? Result { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
