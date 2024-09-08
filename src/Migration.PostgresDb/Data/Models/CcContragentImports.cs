using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcContragentImports
{
    public long Id { get; set; }

    public DateTime? ImportDate { get; set; }

    public short? Success { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
