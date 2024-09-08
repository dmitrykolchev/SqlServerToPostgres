using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcPfoGrafics
{
    public long Id { get; set; }

    public long? BpId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public DateTime? StartDate { get; set; }

    public long? PositionGroupId { get; set; }

    public bool? IsForeign { get; set; }

    public string? Status { get; set; }

    public string? Note { get; set; }

    public long? StationId { get; set; }

    public long? OrgId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
