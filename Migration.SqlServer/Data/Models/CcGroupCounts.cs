using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcGroupCounts
{
    public long Id { get; set; }

    public long? Station { get; set; }

    public long? Count { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
