using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcRtnPostOperatives
{
    public long Id { get; set; }

    public long? PostStructureId { get; set; }

    public long? NppStageId { get; set; }

    public long? MinCount { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
