using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcRtnPostOperativeBlocks
{
    public long Id { get; set; }

    public long? PostOperativeId { get; set; }

    public long? NppBlockId { get; set; }

    public string? Mock { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
