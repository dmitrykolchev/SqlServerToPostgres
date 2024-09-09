using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class StatisticDatas
{
    public long Id { get; set; }

    public long? StatisticRecId { get; set; }

    public double? Value { get; set; }

    public string? ValueStr { get; set; }

    public DateTime? ValueDate { get; set; }

    public string? PeriodType { get; set; }

    public long? PeriodDay { get; set; }

    public long? PeriodMonth { get; set; }

    public long? PeriodQuarter { get; set; }

    public long? PeriodYear { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public DateTime? StatisticDate { get; set; }

    public string? AdditinalInfo { get; set; }

    public long? PeriodMinute { get; set; }

    public long? PeriodHour { get; set; }

    public long? BudgetPeriodId { get; set; }

    public string? ObjectType { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }
}
