using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Orgs
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? DispName { get; set; }

    public long? AccountId { get; set; }

    public long? KpiProfileId { get; set; }

    public List<long>? KpiProfilesId { get; set; }

    public long? BonusProfileId { get; set; }

    public long? PlaceId { get; set; }

    public long? RegionId { get; set; }

    public string? Tags { get; set; }

    public List<long>? TagId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public List<long>? RoleId { get; set; }
}
