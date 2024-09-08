using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class DnSubjectPlans
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Subject { get; set; }

    public long? ProgramDisciplineId { get; set; }

    public long? ProgDiscAppendId { get; set; }

    public long? EducatEventId { get; set; }

    public long? Hours { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
