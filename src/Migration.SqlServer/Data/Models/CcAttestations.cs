using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcAttestations
{
    public long Id { get; set; }

    public long? PersonId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? Result { get; set; }

    public string? Recommend { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
