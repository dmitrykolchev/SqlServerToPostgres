using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CfPkThemes
{
    public long Id { get; set; }

    public string CourseTid { get; set; } = null!;

    public long Tid { get; set; }

    public long CompoundProgramId { get; set; }

    public long CourseId { get; set; }

    public bool Sel { get; set; }

    public int Duration { get; set; }
}
