﻿using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcPfoQualCourseOrders
{
    public long Id { get; set; }

    public long? QualificationId { get; set; }

    public long? CourseId { get; set; }

    public long? CourseOrder { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
