using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcVersions
{
    public long Id { get; set; }

    public long? ObjectId { get; set; }

    public long? Major { get; set; }

    public long? Minor { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
