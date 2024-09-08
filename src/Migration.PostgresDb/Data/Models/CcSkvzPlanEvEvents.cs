using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcSkvzPlanEvEvents
{
    public long Id { get; set; }

    public long? PlanEvId { get; set; }

    public long? EvId { get; set; }

    public string? Code { get; set; }

    public short? IsComplete { get; set; }

    public DateTime? FactDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
