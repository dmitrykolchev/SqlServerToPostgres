using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcQualifications
{
    public long Id { get; set; }

    public long? QualificationId { get; set; }

    public long? PositionGroupId { get; set; }

    public long? AssessmentCriteriaId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public long? StationId { get; set; }
}
