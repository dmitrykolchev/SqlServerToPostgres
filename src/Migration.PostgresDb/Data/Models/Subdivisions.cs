using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Subdivisions
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? OrgId { get; set; }

    public long? ParentObjectId { get; set; }

    public bool? IsDisbanded { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }

    public long? PlaceId { get; set; }

    public long? RegionId { get; set; }

    public long? KpiProfileId { get; set; }

    public List<long>? KpiProfilesId { get; set; }

    public long? BonusProfileId { get; set; }

    public long? CostCenterId { get; set; }

    public bool? IsFaculty { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
