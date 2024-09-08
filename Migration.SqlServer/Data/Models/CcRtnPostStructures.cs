using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcRtnPostStructures
{
    public long Id { get; set; }

    public long? StationId { get; set; }

    public long? PostLicensedId { get; set; }

    public string? InstructionId { get; set; }

    public long? ResponsibleDepartment { get; set; }

    public string? Mock { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
