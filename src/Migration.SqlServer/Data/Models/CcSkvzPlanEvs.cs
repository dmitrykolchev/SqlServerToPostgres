using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcSkvzPlanEvs
{
    public long Id { get; set; }

    public long? KvzPersonId { get; set; }

    public string? Priority { get; set; }

    public long? ResponsibleId { get; set; }

    public DateTime? FactDate { get; set; }

    public string? Code { get; set; }

    public bool? IsComplete { get; set; }

    public string? ProtFileId { get; set; }

    public DateTime? DateComplete { get; set; }

    public bool? MIsComplete { get; set; }

    public DateTime? MDateComplete { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? PlanFileId { get; set; }

    public DateTime? MDateStart { get; set; }
}
