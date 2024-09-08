using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcScmtAssignGroups
{
    public long Id { get; set; }

    public long? Assign { get; set; }

    public string? Name { get; set; }

    public string? ShortName { get; set; }

    public long? Number { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
