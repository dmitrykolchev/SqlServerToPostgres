using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcAccessDivisons
{
    public long Id { get; set; }

    public long? User { get; set; }

    public long? Division { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
