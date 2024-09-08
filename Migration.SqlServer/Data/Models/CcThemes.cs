using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcThemes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
