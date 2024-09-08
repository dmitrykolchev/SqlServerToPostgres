using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcAccessPeriods
{
    public long Id { get; set; }

    public long? Period { get; set; }

    public long? Division { get; set; }

    public long? Status { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
