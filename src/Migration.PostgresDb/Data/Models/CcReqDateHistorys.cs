using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcReqDateHistorys
{
    public long Id { get; set; }

    public long? RequestId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public long? PersonId { get; set; }

    public string? Reason { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
