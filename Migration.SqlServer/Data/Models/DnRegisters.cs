using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class DnRegisters
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? ControlEventId { get; set; }

    public string? TypeId { get; set; }

    public long? FacultyId { get; set; }

    public long? ChairId { get; set; }

    public long? DisciplId { get; set; }

    public long? LectorId { get; set; }

    public DateTime? DateEvent { get; set; }

    public long? ContrFormId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
