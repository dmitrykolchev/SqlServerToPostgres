using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class DnSchedules
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? Faculty { get; set; }

    public long? Chair { get; set; }

    public long? AcademYearId { get; set; }

    public long? TermId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
