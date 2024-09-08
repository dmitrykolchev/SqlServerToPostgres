using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CourseParts
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? CourseId { get; set; }

    public string? PartCode { get; set; }

    public string? ParentPartCode { get; set; }

    public string? PartName { get; set; }

    public string? PartType { get; set; }

    public long? CourseModuleId { get; set; }

    public long? AssessmentId { get; set; }

    public long? ActivityId { get; set; }

    public long? ObjectId { get; set; }
}
