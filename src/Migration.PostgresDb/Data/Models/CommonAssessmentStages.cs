using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonAssessmentStages
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public bool? IsPeriodDependent { get; set; }

    public string? Access { get; set; }
}
