using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcStaffevalUtpDivs
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Station { get; set; }

    public string? Subdivision { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? SubdivPlan { get; set; }

    public long? SubdivFact { get; set; }

    public long? SubdivPlanI { get; set; }

    public long? SubdivFactI { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
