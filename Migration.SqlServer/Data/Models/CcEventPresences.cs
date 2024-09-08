using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcEventPresences
{
    public long Id { get; set; }

    public long? EventId { get; set; }

    public long? PersonId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
