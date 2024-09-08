using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class DnIndEducatPlans
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? StudentId { get; set; }

    public long? DisciplineId { get; set; }

    public long? ProgDisciplId { get; set; }

    public long? ControlFormId { get; set; }

    public string? IsCourseWork { get; set; }

    public string? ThemeCourseWork { get; set; }

    public long? ChairId { get; set; }

    public long? LectorId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
