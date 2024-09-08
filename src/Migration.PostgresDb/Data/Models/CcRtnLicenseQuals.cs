using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcRtnLicenseQuals
{
    public long Id { get; set; }

    public long? LicenseActivityId { get; set; }

    public long? LicenseId { get; set; }

    public long? PostLicensedId { get; set; }

    public long? ActivityId { get; set; }

    public DateTime? BeginDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? DocProps { get; set; }

    public short? FlDistance { get; set; }

    public short? FlSuccess { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
