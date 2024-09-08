using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcEdufieldApps
{
    public long Id { get; set; }

    public long? EduFieldId { get; set; }

    public long? EduappId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
