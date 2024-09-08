using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class FuncManagers
{
    public long Id { get; set; }

    public string? Catalog { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public long? SubordinatePositionId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? PersonPositionId { get; set; }

    public string? StaffObjectType { get; set; }

    public long? StaffObjectId { get; set; }

    public string? StaffObjectName { get; set; }

    public bool? IsNative { get; set; }

    public long? BossTypeId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool? IsFinished { get; set; }

    public long? ParentId { get; set; }

    public long? OrgId { get; set; }
}
