using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class EducationMethodLectors
{
    public long Id { get; set; }

    public long? EducationMethodId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? StateId { get; set; }

    public bool? IsOpen { get; set; }

    public long? EducationOrgId { get; set; }

    public double? Cost { get; set; }

    public double? CostNds { get; set; }

    public string? Currency { get; set; }

    public string? CostType { get; set; }

    public long? Duration { get; set; }

    public long? DurationDays { get; set; }

    public long? PersonNum { get; set; }

    public long? LectorId { get; set; }
}
