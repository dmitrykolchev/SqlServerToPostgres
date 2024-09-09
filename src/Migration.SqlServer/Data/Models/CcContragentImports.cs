using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcContragentImports
{
    public long Id { get; set; }

    public DateTime? ImportDate { get; set; }

    public bool? Success { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
