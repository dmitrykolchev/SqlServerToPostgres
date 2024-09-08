using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcCostHistorys
{
    public long Id { get; set; }

    public long? CourseId { get; set; }

    public long? BudgetPeriodId { get; set; }

    public double? Cost { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
