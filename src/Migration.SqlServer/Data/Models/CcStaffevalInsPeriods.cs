using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcStaffevalInsPeriods
{
    public long Id { get; set; }

    public DateTime? AddDate { get; set; }

    public long? Period { get; set; }

    public long? PersonId { get; set; }

    public long? InstructorId { get; set; }

    public string? OrderFile { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
