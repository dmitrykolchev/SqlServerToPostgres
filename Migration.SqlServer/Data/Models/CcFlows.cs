using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcFlows
{
    public long Id { get; set; }

    public string? Session { get; set; }

    public DateTime? AddDate { get; set; }

    public bool? IsEnd { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
