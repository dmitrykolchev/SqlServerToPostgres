using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcProgramDates
{
    public long Id { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public long? Program { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
