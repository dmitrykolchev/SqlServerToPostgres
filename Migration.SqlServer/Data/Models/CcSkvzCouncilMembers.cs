using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcSkvzCouncilMembers
{
    public long Id { get; set; }

    public long? PersonId { get; set; }

    public long? StationId { get; set; }

    public DateTime? SendingDate { get; set; }

    public bool? Complete { get; set; }

    public long? ActivityId { get; set; }

    public string? Code { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
