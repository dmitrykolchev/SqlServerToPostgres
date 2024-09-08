using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcPfoQualificationPositions
{
    public long Id { get; set; }

    public long? QualificationId { get; set; }

    public long? PositionId { get; set; }

    public long? StationId { get; set; }

    public long? DivisionId { get; set; }

    public string? PositionName { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
