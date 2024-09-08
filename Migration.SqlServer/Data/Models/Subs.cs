using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Subs
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public long? OrgId { get; set; }

    public long? ParentId { get; set; }

    public long? BasicCollaboratorId { get; set; }

    public string? BasicCollaboratorFullname { get; set; }

    public bool? IsBoss { get; set; }

    public bool? IsDisbanded { get; set; }
}
