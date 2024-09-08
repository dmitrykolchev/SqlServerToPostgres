using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcSkvzBpApprovedObjects
{
    public long Id { get; set; }

    public long? BpId { get; set; }

    public short? SkvzSpWait { get; set; }

    public short? SkvzSp { get; set; }

    public short? WorkGroup { get; set; }

    public short? WorkGroupWait { get; set; }

    public string? Code { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
