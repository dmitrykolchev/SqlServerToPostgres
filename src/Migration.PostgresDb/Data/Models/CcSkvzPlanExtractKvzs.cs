using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcSkvzPlanExtractKvzs
{
    public long Id { get; set; }

    public long? KvzPersonId { get; set; }

    public string? Kvz { get; set; }

    public DateTime? FactDate { get; set; }

    public short? IsComplete { get; set; }

    public string? Code { get; set; }

    public long? ExtractKvzTypeId { get; set; }

    public short? MIsComplete { get; set; }

    public DateTime? MFactDate { get; set; }

    public short? IsInPoll { get; set; }

    public short? IsPollComplete { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public DateTime? MStartDate { get; set; }
}
