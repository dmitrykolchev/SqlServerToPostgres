using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Bps
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ParentBpId { get; set; }
}
