using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcPfoMethodScales
{
    public long Id { get; set; }

    public long? MethodId { get; set; }

    public string? Code { get; set; }

    public long? ScaleOrder { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
