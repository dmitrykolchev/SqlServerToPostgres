using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcRtnLicenseSkillResults
{
    public long Id { get; set; }

    public long? LicenseSkillId { get; set; }

    public DateTime? FactDate { get; set; }

    public long? ResultId { get; set; }

    public string? ProtocolId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
