using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Covenants
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? CloseDate { get; set; }

    public long? PeriodWork { get; set; }

    public double? Cost { get; set; }

    public double? CostNds { get; set; }

    public string? Currency { get; set; }

    public long? ProcPayBank { get; set; }

    public long? ProcPayCollab { get; set; }

    public long? ProcDeduct { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? EducationMethodId { get; set; }

    public long? EventId { get; set; }

    public string? StatusId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
