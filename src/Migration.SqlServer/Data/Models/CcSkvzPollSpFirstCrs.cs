using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcSkvzPollSpFirstCrs
{
    public long Id { get; set; }

    public long? SpFirstResultId { get; set; }

    public long? CriteriaActivityId { get; set; }

    public string? Code { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
