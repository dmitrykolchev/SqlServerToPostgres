using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CourseCollaborators
{
    public long Id { get; set; }

    public long? CourseId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }
}
