using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcRtnLicenseControlResults
{
    public long Id { get; set; }

    public long? LicenseControlId { get; set; }

    public DateTime? FactDate { get; set; }

    public long? ResultId { get; set; }

    public string? ProtocolId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
