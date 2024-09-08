using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcRtnLicenseControls
{
    public long Id { get; set; }

    public long? LicenseId { get; set; }

    public long? ControlId { get; set; }

    public long? Year { get; set; }

    public long? ControlKindId { get; set; }

    public DateTime? SuccessDate { get; set; }

    public DateTime? DeadlineDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
