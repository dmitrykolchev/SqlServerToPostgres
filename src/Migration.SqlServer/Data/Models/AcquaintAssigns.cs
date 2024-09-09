using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class AcquaintAssigns
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectName { get; set; }

    public DateTime? NormativeDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public long? ReacquaintancePeriod { get; set; }

    public long? PersonId { get; set; }

    public long? AcquaintId { get; set; }

    public string? StateId { get; set; }

    public long? AttemptNum { get; set; }

    public DateTime? ModificationDate { get; set; }
}
