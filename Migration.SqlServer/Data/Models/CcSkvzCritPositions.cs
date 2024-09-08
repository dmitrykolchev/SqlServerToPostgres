using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcSkvzCritPositions
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? StationId { get; set; }

    public long? DivId { get; set; }

    public long? PlanCnt { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
