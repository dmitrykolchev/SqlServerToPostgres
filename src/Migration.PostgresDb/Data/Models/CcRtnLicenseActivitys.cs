using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcRtnLicenseActivitys
{
    public long Id { get; set; }

    public long? LicenseId { get; set; }

    public long? ActivityId { get; set; }

    public long? Year { get; set; }

    public short? FlSuccess { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
