using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class KpiManagers
{
    public long Id { get; set; }

    public string? ObjectType { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public string? ManagerType { get; set; }

    public long? ManagerId { get; set; }

    public string? ManagerName { get; set; }

    public bool? IsOwner { get; set; }

    public long? BossTypeId { get; set; }
}
