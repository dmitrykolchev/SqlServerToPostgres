using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class KpiValues
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? KpiId { get; set; }

    public long? BudgetPeriodId { get; set; }

    public long? ResponsibleId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? Fact { get; set; }

    public double? Value { get; set; }

    public string? ObjectCatalog { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public DateTime? ModificationDate { get; set; }
}
