using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcRtnExamMedicals
{
    public long Id { get; set; }

    public long? CollaboratorId { get; set; }

    public DateTime? PlanDate { get; set; }

    public DateTime? FactDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
