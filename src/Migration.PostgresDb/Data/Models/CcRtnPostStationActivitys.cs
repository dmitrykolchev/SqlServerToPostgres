using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcRtnPostStationActivitys
{
    public long Id { get; set; }

    public long? PostStationId { get; set; }

    public long? ActivityId { get; set; }

    public string? Mock { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
