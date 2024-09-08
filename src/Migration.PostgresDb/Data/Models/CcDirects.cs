using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcDirects
{
    public long Id { get; set; }

    public string? Class { get; set; }

    public string? Method { get; set; }

    public string? Type { get; set; }

    public long? Object { get; set; }

    public short? Isform { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
