using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcRtnLicenseDoublings
{
    public long Id { get; set; }

    public long? LicenseId { get; set; }

    public DateTime? BeginDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? OrderProps { get; set; }

    public bool? FlSuccess { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
