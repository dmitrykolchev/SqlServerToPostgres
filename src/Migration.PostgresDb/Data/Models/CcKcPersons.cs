using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcKcPersons
{
    public long Id { get; set; }

    public long? PersonId { get; set; }

    public long? EventId { get; set; }

    public string? Number { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
