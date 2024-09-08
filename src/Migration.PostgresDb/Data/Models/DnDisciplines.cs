using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class DnDisciplines
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? DisciplBlockId { get; set; }

    public long? FacultyId { get; set; }

    public long? ChairId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
