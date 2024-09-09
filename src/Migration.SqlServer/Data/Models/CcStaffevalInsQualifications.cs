using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcStaffevalInsQualifications
{
    public long Id { get; set; }

    public long? InstructorId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? Org { get; set; }

    public string? Type { get; set; }

    public string? Course { get; set; }

    public long? Num { get; set; }

    public string? Place { get; set; }

    public string? AnotherPlace { get; set; }

    public string? UtpDivision { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
