using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcLogImports
{
    public long Id { get; set; }

    public DateTime? Date { get; set; }

    public long? Num { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
