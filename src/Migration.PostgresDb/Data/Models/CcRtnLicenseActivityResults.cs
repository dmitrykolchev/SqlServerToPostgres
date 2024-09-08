using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcRtnLicenseActivityResults
{
    public long Id { get; set; }

    public long? LicenseActivityId { get; set; }

    public DateTime? RtnPlanDate { get; set; }

    public DateTime? RtnFactDate { get; set; }

    public DateTime? CaConcernFactDate { get; set; }

    public DateTime? ExamDate { get; set; }

    public long? ResultId { get; set; }

    public long? ResultFailNumber { get; set; }

    public string? ProtocolId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
