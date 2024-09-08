using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Sites
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? WebDesignId { get; set; }

    public string? LngId { get; set; }

    public bool? IsStd { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? OwnerObject { get; set; }
}
