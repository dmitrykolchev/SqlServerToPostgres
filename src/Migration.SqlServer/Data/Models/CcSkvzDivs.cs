using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcSkvzDivs
{
    public long Id { get; set; }

    public long? DivId { get; set; }

    public long? StationId { get; set; }

    public long? CouncilMemberId { get; set; }

    public long? HeadId { get; set; }

    public string? Code { get; set; }

    public long? StationBlockTypeId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
