using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcRtnPostStations
{
    public long Id { get; set; }

    public long? StationId { get; set; }

    public string? Code { get; set; }

    public long? PostApprovedId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
