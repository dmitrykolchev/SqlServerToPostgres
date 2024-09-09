using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcPfoScaleResults
{
    public long Id { get; set; }

    public long? ResultId { get; set; }

    public long? ScaleId { get; set; }

    public string? Value { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
