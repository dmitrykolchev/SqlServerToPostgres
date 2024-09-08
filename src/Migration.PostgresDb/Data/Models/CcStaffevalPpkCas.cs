using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcStaffevalPpkCas
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? SpResponsible { get; set; }

    public string? PositionCategory1 { get; set; }

    public string? PositionCategory2 { get; set; }

    public short? Rostehnadzor { get; set; }

    public DateTime? StartYear { get; set; }

    public DateTime? EndYear { get; set; }

    public string? PpkLocation { get; set; }

    public long? TheoreticalHours { get; set; }

    public string? StationsListPpk { get; set; }

    public short? EditEnabled { get; set; }

    public long? CreatorId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
