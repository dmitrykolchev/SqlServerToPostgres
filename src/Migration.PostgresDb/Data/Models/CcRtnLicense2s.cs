using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcRtnLicense2s
{
    public long Id { get; set; }

    public long? CollaboratorId { get; set; }

    public long? StationId { get; set; }

    public long? PrepareStateId { get; set; }

    public short? FlOperative { get; set; }

    public long? ResponsibleId { get; set; }

    public long? LicenseHolderTypeId { get; set; }

    public long? ParentId { get; set; }

    public long? ResponsibleDepartment { get; set; }

    public string? Mock { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
