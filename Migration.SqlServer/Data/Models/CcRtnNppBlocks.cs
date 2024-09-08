using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcRtnNppBlocks
{
    public long Id { get; set; }

    public long? StationId { get; set; }

    public long? StageId { get; set; }

    public string? Name { get; set; }

    public bool? FlActive { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
