using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class PolicyTypes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Provider { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
