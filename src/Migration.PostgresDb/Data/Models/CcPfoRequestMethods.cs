using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcPfoRequestMethods
{
    public long Id { get; set; }

    public long? PfoRequestId { get; set; }

    public long? CourseId { get; set; }

    public long? AssessmentId { get; set; }

    public short? NeedAssign { get; set; }

    public short? AddManually { get; set; }

    public short? AlwaysShowToPerson { get; set; }

    public string? Code { get; set; }

    public short? SaveOnClose { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? FinishReason { get; set; }
}
