using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcSkvzYearPlans
{
    public long Id { get; set; }

    public long? BpId { get; set; }

    public long? YearPlanEventId { get; set; }

    public DateTime? PlanDate { get; set; }

    public DateTime? FactDate { get; set; }

    public string? Code { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? PlanFileId { get; set; }
}
