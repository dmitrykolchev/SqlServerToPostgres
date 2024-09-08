using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcDocFields
{
    public long Id { get; set; }

    public long? PrintForm { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? Obj { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
