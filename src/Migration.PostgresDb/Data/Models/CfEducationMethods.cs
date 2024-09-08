using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CfEducationMethods
{
    public long EducationMethodId { get; set; }

    public DateTime? FStartActive { get; set; }

    public DateTime? FFinishActive { get; set; }

    public long? FThemes { get; set; }

    public long? FEduField { get; set; }

    public long? FEduType { get; set; }

    public short? IsNds { get; set; }

    public long FDivision { get; set; }

    public short? IsSp { get; set; }

    public short? IsIpk { get; set; }

    public long? FReason { get; set; }

    public string? FReasonText { get; set; }

    public int? FDurationPractice { get; set; }

    public string? MigrationId { get; set; }

    public short? IsCentral { get; set; }

    public short? IsEdu { get; set; }

    public long? FFileReason { get; set; }

    public short? EditForbidden { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
