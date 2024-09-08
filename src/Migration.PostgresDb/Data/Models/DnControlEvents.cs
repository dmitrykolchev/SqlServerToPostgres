using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class DnControlEvents
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public DateTime? DateEvent { get; set; }

    public string? StatusId { get; set; }

    public long? FacultyId { get; set; }

    public long? ChairId { get; set; }

    public long? DisciplId { get; set; }

    public long? LectorId { get; set; }

    public long? ControlFormId { get; set; }

    public long? LessonId { get; set; }

    public long? StreamId { get; set; }

    public long? StudGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
