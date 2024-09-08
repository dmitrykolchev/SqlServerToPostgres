using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcFlows
{
    public long Id { get; set; }

    public string? Session { get; set; }

    public DateTime? AddDate { get; set; }

    public short? IsEnd { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
