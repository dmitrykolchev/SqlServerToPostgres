using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CompoundProgramEducationMethods
{
    public long Id { get; set; }

    public long? CompoundProgramId { get; set; }

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

    public long? ProgramId { get; set; }

    public long? ParentProgpamId { get; set; }

    public long? Position { get; set; }

    public string? ObjectType { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public string? ObjectCode { get; set; }
}
