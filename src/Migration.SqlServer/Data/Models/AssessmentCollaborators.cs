using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class AssessmentCollaborators
{
    public long Id { get; set; }

    public long? AssessmentId { get; set; }

    public string? Code { get; set; }

    public string? Title { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? Type { get; set; }
}
