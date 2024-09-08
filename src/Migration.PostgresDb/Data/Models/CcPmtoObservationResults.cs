using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcPmtoObservationResults
{
    public long Id { get; set; }

    public long? Observation { get; set; }

    public string? Result4 { get; set; }

    public string? Result5 { get; set; }

    public string? Result6 { get; set; }

    public string? Result7 { get; set; }

    public string? Result8 { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
