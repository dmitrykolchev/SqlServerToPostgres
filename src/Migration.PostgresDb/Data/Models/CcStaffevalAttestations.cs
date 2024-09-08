using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcStaffevalAttestations
{
    public long Id { get; set; }

    public long? Number { get; set; }

    public long? StationId { get; set; }

    public DateTime? DatePlan { get; set; }

    public DateTime? DateFactFrom { get; set; }

    public string? OrderEvent { get; set; }

    public string? OrderResults { get; set; }

    public string? OrderCorrection { get; set; }

    public string? Report { get; set; }

    public string? CreatorId { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? DateFactTo { get; set; }

    public string? Correction { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
