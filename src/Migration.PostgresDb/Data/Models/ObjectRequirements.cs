using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ObjectRequirements
{
    public long Id { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectName { get; set; }

    public string? RequirementType { get; set; }

    public long? RequirementObjectId { get; set; }

    public string? RequirementObjectType { get; set; }

    public long? SecRequirementObjectId { get; set; }

    public string? SecRequirementObjectType { get; set; }

    public bool? Obligatory { get; set; }

    public string? RequirementValue { get; set; }

    public string? AdditionalParam { get; set; }
}
