using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class PositionAssessmentForms
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? PersonId { get; set; }

    public long? PositionCommonId { get; set; }

    public bool? IsDone { get; set; }

    public long? AssessmentAppraiseId { get; set; }

    public long? Scale { get; set; }

    public long? GradeId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
