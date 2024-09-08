using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcPfoDivs
{
    public long Id { get; set; }

    public long? DivId { get; set; }

    public long? StationId { get; set; }

    public long? HeadId { get; set; }

    public string? Comment { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
