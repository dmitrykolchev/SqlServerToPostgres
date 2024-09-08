using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class QaTestResults
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? TestId { get; set; }

    public long? TestSetId { get; set; }

    public long? TestParamsetId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? WorkStatus { get; set; }

    public string? FinishStatus { get; set; }

    public long? ErrorCode { get; set; }

    public long? Duration { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
