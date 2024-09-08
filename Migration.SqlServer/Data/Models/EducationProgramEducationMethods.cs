﻿using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class EducationProgramEducationMethods
{
    public long Id { get; set; }

    public long? EducationProgramId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? EducationMethodId { get; set; }

    public string? EducationMethodName { get; set; }

    public double? Cost { get; set; }

    public string? Currency { get; set; }

    public string? CostType { get; set; }

    public long? Duration { get; set; }

    public long? PersonNum { get; set; }

    public string? Type { get; set; }

    public bool? IsOpen { get; set; }

    public long? DurationDays { get; set; }
}
