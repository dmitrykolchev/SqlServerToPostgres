using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class DnRegisterStudents
{
    public long Id { get; set; }

    public long? RegisterId { get; set; }

    public string? Code { get; set; }

    public long? DisciplId { get; set; }

    public long? LectorId { get; set; }

    public DateTime? DateEvent { get; set; }

    public long? ContrFormId { get; set; }

    public long? StudentId { get; set; }

    public string? PersonFullname { get; set; }
}
