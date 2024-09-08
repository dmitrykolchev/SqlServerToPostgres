using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class DnProgramDiscipls
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? StatusId { get; set; }

    public long? FacultyId { get; set; }

    public long? ChairId { get; set; }

    public long? DisciplineId { get; set; }

    public long? AcademYearId { get; set; }

    public long? AllLaboriousnAudit { get; set; }

    public long? AllLaboriousnIndep { get; set; }

    public long? ControlForm { get; set; }

    public long? EducatFormId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
