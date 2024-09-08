using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class EventAssessmentPlans
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? EventId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonPositionName { get; set; }

    public long? ExpertPersonId { get; set; }

    public string? ExpertPersonFullname { get; set; }

    public string? ExpertPersonPositionName { get; set; }

    public DateTime? DateStart { get; set; }

    public bool? IsDone { get; set; }

    public string? AssessmentType { get; set; }

    public string? AssessmentTypeId { get; set; }

    public string? Status { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
