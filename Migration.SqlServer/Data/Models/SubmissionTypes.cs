using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class SubmissionTypes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? PeriodityId { get; set; }
}
