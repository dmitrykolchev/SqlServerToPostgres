using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcSkvzYearPlanEvents
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public short? IsPlan { get; set; }

    public long? OrderNum { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
