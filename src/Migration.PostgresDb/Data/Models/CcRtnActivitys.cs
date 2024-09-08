using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcRtnActivitys
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public short? Place { get; set; }

    public short? FlActive { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
