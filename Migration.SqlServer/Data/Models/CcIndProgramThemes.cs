using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcIndProgramThemes
{
    public long Id { get; set; }

    public long? IndProgramId { get; set; }

    public long? CourseId { get; set; }

    public string? TaskId { get; set; }

    public long? ThemeId { get; set; }

    public long? Duration { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
