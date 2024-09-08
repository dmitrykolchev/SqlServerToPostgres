using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonAssessmentAppraiseTypes
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public bool? General { get; set; }

    public long? Index { get; set; }
}
