using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcPfoRequestToLearnings
{
    public long Id { get; set; }

    public long? PfoRequestId { get; set; }

    public long? ActiveLearningId { get; set; }

    public long? AssessmentId { get; set; }

    public long? PfoMethodId { get; set; }

    public string? Code { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
