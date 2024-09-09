using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcSelftestDbs
{
    public long Id { get; set; }

    public string? Method { get; set; }

    public long? MethodCode { get; set; }

    public string? Cnt { get; set; }

    public long? ExpertId { get; set; }

    public DateTime? Date { get; set; }

    public string? Fact { get; set; }

    public long? ModelId { get; set; }

    public long? ModelCode { get; set; }

    public string? Direction { get; set; }

    public long? BpId { get; set; }

    public string? UserId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
