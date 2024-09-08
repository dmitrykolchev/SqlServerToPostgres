using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcPfoRequestTransfers
{
    public long Id { get; set; }

    public long? RequestId { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public DateTime? TransferDate { get; set; }

    public string? Reason { get; set; }

    public string? NumDoc { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
