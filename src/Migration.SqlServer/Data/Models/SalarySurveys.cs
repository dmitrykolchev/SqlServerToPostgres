using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class SalarySurveys
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public double? MinSalary { get; set; }

    public double? MaxSalary { get; set; }

    public double? AvgSalary { get; set; }

    public string? Currency { get; set; }

    public long? PositionCommonId { get; set; }

    public string? PositionName { get; set; }

    public long? PositionLevelId { get; set; }

    public long? SalarySurveySourceId { get; set; }

    public long? BudgetPeriodId { get; set; }

    public long? RegionId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
