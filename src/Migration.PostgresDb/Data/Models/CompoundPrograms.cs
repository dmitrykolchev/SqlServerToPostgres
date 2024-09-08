using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CompoundPrograms
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public long? MinPersonNum { get; set; }

    public long? Duration { get; set; }

    public bool? AllowSelfAssignment { get; set; }

    public List<long>? LectorsId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public List<long>? RoleId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public List<long>? ObjectsId { get; set; }
}
