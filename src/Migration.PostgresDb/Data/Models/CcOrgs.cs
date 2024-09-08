using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcOrgs
{
    public long Id { get; set; }

    public long? OrgId { get; set; }

    public string? Inn { get; set; }

    public string? Kpp { get; set; }

    public long? StationId { get; set; }

    public string? OrgType { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
