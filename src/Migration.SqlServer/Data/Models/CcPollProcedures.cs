using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcPollProcedures
{
    public long Id { get; set; }

    public long? PollProcedureId { get; set; }

    public long? BpId { get; set; }

    public long? StationId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
