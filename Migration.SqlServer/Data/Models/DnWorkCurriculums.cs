using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class DnWorkCurriculums
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? StatusId { get; set; }

    public string? Type { get; set; }

    public long? StudentId { get; set; }

    public long? AcademYearId { get; set; }

    public long? FacultyId { get; set; }

    public long? ChairId { get; set; }

    public long? SpecialId { get; set; }

    public long? SpecializationId { get; set; }

    public long? QualificationId { get; set; }

    public long? EducatFormId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
