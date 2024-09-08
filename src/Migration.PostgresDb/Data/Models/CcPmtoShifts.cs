using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcPmtoShifts
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? Station { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
