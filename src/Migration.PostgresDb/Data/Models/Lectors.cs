using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Lectors
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? ResourceId { get; set; }

    public string? Type { get; set; }

    public string? LectorFullname { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonPositionName { get; set; }

    public string? PersonSubdivisionName { get; set; }

    public string? Email { get; set; }

    public bool? IsDismiss { get; set; }

    public bool? AllowPublication { get; set; }

    public List<long>? RoleId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
