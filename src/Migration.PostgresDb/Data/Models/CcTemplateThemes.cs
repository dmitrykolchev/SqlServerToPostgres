using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcTemplateThemes
{
    public long Id { get; set; }

    public long? TemplateId { get; set; }

    public long? CourseId { get; set; }

    public long? ThemeId { get; set; }

    public string? TaskId { get; set; }

    public long? Duration { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
