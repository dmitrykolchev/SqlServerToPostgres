using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcRtnLicenseSkills
{
    public long Id { get; set; }

    public long? LicensePostId { get; set; }

    public long? Year { get; set; }

    public long? ControlKindId { get; set; }

    public DateTime? SuccessDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
