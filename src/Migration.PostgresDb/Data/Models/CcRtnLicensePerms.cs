using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcRtnLicensePerms
{
    public long Id { get; set; }

    public long? LicenseActivityId { get; set; }

    public string? DocProps { get; set; }

    public long? StateId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
