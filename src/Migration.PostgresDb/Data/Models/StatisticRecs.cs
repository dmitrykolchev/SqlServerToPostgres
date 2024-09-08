﻿using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class StatisticRecs
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public bool? IsEnabled { get; set; }

    public bool? AutoCalc { get; set; }

    public DateTime? LastCalculateDate { get; set; }

    public long? CalcPeriod { get; set; }

    public bool? ContextCalc { get; set; }

    public bool? ReadyToAnalytics { get; set; }

    public string? CatalogName { get; set; }

    public List<string>? PeriodType { get; set; }

    public string? PeriodCalcType { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public long? Depth { get; set; }

    public double? NormFrom { get; set; }

    public double? NormTo { get; set; }

    public long? NotificationTypeId { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }

    public List<long>? RoleId { get; set; }

    public List<string>? Catalog { get; set; }

    public string? AccessBlockType { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
