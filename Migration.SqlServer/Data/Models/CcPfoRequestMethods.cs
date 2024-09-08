﻿using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcPfoRequestMethods
{
    public long Id { get; set; }

    public long? PfoRequestId { get; set; }

    public long? CourseId { get; set; }

    public long? AssessmentId { get; set; }

    public bool? NeedAssign { get; set; }

    public bool? AddManually { get; set; }

    public bool? AlwaysShowToPerson { get; set; }

    public string? Code { get; set; }

    public bool? SaveOnClose { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? FinishReason { get; set; }
}
