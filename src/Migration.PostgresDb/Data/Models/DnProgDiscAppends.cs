using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class DnProgDiscAppends
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ProgramDisciplineId { get; set; }

    public long? AcademYearId { get; set; }

    public long? SpecialId { get; set; }

    public long? SpecializationId { get; set; }

    public string? EducatFormId { get; set; }

    public long? QualificationId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
