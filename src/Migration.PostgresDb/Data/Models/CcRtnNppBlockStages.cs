using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcRtnNppBlockStages
{
    public long Id { get; set; }

    public long? StationId { get; set; }

    public string? Name { get; set; }

    public short? FlActive { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
