using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcAccessElements
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Role { get; set; }

    public long? Group { get; set; }

    public short? All { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
