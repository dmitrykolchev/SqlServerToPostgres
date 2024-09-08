using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class EducationOrgLectors
{
    public long Id { get; set; }

    public long? EducationOrgId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? DispName { get; set; }

    public bool? IsProviderCourses { get; set; }

    public long? LectorId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }
}
