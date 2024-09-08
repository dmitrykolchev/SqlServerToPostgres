using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class SubdivisionGroups
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public bool? IsDynamic { get; set; }

    public long? KpiProfileId { get; set; }

    public List<long>? KpiProfilesId { get; set; }

    public long? BonusProfileId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }
}
