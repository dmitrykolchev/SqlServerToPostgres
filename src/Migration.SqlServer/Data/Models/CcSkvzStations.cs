using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcSkvzStations
{
    public long Id { get; set; }

    public long? StationId { get; set; }

    public string? ReactorType { get; set; }

    public string? Code { get; set; }

    public long? UtpHeadId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
