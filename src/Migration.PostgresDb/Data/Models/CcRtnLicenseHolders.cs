using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcRtnLicenseHolders
{
    public long Id { get; set; }

    public long? LicenseActivityId { get; set; }

    public string? Number { get; set; }

    public DateTime? BeginDate { get; set; }

    public DateTime? EndDate { get; set; }

    public long? LicenseStateId { get; set; }

    public short? FlActive { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
