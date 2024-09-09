using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcStaffevalPollsPUsers
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? ProcedureId { get; set; }

    public long? UserId { get; set; }

    public DateTime? SendDate { get; set; }

    public long? SendCounter { get; set; }

    public DateTime? LastSendDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
