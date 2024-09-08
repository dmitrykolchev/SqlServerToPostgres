using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class ScheduleDays
{
    public long Id { get; set; }

    public long? ScheduleTypeId { get; set; }

    public string? ScheduleTypeName { get; set; }

    public long? BudgetPeriodId { get; set; }

    public DateTime? Date { get; set; }

    public string? StartTime { get; set; }

    public string? FinishTime { get; set; }
}
