using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcRtnLicensePost2s
{
    public long Id { get; set; }

    public long? LicenseId { get; set; }

    public long? PostLicensedId { get; set; }

    public bool? FlHeldPost { get; set; }

    public string? Mock { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
