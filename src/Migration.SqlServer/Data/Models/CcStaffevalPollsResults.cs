using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcStaffevalPollsResults
{
    public long Id { get; set; }

    public long? ProcedureId { get; set; }

    public string? Result { get; set; }

    public DateTime? Date { get; set; }

    public long? StationId { get; set; }

    public long? UserId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
