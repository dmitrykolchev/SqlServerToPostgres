using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

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

    public bool? FlDistance { get; set; }

    public bool? FlSuccess { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
