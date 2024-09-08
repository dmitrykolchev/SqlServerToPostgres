using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcStaffevalTestPollsUs
{
    public long Id { get; set; }

    public long? ProcedureId { get; set; }

    public long? UserId { get; set; }

    public DateTime? SendDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
