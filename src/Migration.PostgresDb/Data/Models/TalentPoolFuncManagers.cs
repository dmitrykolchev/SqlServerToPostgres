using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class TalentPoolFuncManagers
{
    public long Id { get; set; }

    public string? Catalog { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public bool? IsNative { get; set; }

    public long? BossTypeId { get; set; }
}
