using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class TrashDocs
{
    public long Id { get; set; }

    public string? ObjectName { get; set; }

    public DateTime? DelDate { get; set; }

    public string? Desc { get; set; }
}
