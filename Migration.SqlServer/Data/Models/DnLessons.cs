using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class DnLessons
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? FacultyId { get; set; }

    public long? ChairId { get; set; }

    public long? DisciplineId { get; set; }

    public DateTime? LessonDate { get; set; }

    public string? StatusId { get; set; }

    public long? LectorId { get; set; }

    public long? EducatEventFormId { get; set; }

    public long? AuditoriumId { get; set; }

    public long? StreamId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
