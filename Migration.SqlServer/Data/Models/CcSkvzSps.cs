using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcSkvzSps
{
    public long Id { get; set; }

    public long? BpId { get; set; }

    public long? DivId { get; set; }

    public long? DelegateId { get; set; }

    public long? ActivityId { get; set; }

    public string? Code { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? OrderFileId { get; set; }
}
