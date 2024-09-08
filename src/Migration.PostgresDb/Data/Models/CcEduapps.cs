using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcEduapps
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public short? Gpgr { get; set; }

    public short? Archive { get; set; }

    public long? Station { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public long? PlanPeriod { get; set; }
}
