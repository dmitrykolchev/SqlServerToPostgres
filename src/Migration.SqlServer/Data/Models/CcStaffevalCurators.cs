using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcStaffevalCurators
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public long? Parent { get; set; }

    public long? Responsible { get; set; }

    public long? StationId { get; set; }

    public long? CreatorId { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? LastEditorId { get; set; }

    public string? EditDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
