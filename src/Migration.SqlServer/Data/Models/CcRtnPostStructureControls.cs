using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcRtnPostStructureControls
{
    public long Id { get; set; }

    public long? PostStructureId { get; set; }

    public long? ControlTypeId { get; set; }

    public long? ControlPeriod { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
