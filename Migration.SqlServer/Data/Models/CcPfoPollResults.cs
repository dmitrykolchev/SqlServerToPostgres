using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcPfoPollResults
{
    public long Id { get; set; }

    public long? PfoPollProcedureId { get; set; }

    public string? ResultItems { get; set; }

    public DateTime? ResultDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
