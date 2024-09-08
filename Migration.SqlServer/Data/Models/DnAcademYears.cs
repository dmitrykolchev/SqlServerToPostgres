using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class DnAcademYears
{
    public long Id { get; set; }

    public string? StartYear { get; set; }

    public string? EndYear { get; set; }

    public string? Name { get; set; }

    public long? AmountWeekAutumnalTerm { get; set; }

    public long? AmountWeekSpringTerm { get; set; }

    public string? StrYears { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
