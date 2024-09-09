using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcCourseDates
{
    public long Id { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public long? Course { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
