using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcSkvzBpApprovedObjects
{
    public long Id { get; set; }

    public long? BpId { get; set; }

    public bool? SkvzSpWait { get; set; }

    public bool? SkvzSp { get; set; }

    public bool? WorkGroup { get; set; }

    public bool? WorkGroupWait { get; set; }

    public string? Code { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
