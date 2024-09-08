using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcPmtoObservations
{
    public long Id { get; set; }

    public long? Station { get; set; }

    public string? Theme { get; set; }

    public long? TypePmt { get; set; }

    public long? TypePlan { get; set; }

    public DateTime? Date { get; set; }

    public string? Block { get; set; }

    public string? Shift { get; set; }

    public long? AuthorId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long? ModifedId { get; set; }

    public DateTime? ModifedDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
