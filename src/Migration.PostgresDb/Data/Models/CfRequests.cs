using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CfRequests
{
    public long Id { get; set; }

    public long? PersonId { get; set; }

    public long? EduType { get; set; }

    public long? Individual { get; set; }

    public long? SourceRequest { get; set; }

    public long? NInd { get; set; }

    public long? FReason { get; set; }

    public double? PlanCost { get; set; }

    public short? IsCentral { get; set; }

    public short? IsOut { get; set; }

    public short? IsEdu { get; set; }

    public string? Mvz1 { get; set; }

    public string? Mvz2 { get; set; }

    public short? IsFinished { get; set; }

    public long? Subdivision { get; set; }

    public int? PersonNum { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public long? RejectReason { get; set; }

    public string? Reason { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
