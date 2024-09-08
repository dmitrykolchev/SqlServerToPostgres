using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcPfoRequests
{
    public long Id { get; set; }

    public long? GraficId { get; set; }

    public long? AssessmentCriteriaId { get; set; }

    public long? PersonId { get; set; }

    public long? CommonPositionId { get; set; }

    public long? Month { get; set; }

    public DateTime? PlanStartDate { get; set; }

    public DateTime? PlanFinishDate { get; set; }

    public short? IsAssigned { get; set; }

    public short? AddManualy { get; set; }

    public DateTime? FactDate { get; set; }

    public long? BpId { get; set; }

    public long? ResultGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? RejectReason { get; set; }
}
