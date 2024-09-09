using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class DnTrainMethodComplexs
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? FacultyId { get; set; }

    public long? ChairId { get; set; }

    public long? DisciplineId { get; set; }

    public long? ProgramDisciplineId { get; set; }

    public string? ProgramDisciplineName { get; set; }

    public long? LectorId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
