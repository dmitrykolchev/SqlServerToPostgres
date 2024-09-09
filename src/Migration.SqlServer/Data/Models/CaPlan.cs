using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CaPlan
{
    public int Id { get; set; }

    public int Year { get; set; }

    public int Phase { get; set; }

    public long Station { get; set; }

    public long BudgetPeriod { get; set; }

    public virtual ICollection<CaApprove> CaApprove { get; set; } = new List<CaApprove>();

    public virtual ICollection<CaPlanUpdates> CaPlanUpdates { get; set; } = new List<CaPlanUpdates>();
}
