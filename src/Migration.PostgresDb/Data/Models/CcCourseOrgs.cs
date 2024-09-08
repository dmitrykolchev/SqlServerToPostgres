using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcCourseOrgs
{
    public long Id { get; set; }

    public long? EducationMethodId { get; set; }

    public long? EducationOrgId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
