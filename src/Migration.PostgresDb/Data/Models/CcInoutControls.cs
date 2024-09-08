using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcInoutControls
{
    public long Id { get; set; }

    public long? EventId { get; set; }

    public long? PersonId { get; set; }

    public long? InNum { get; set; }

    public long? OutNum { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
