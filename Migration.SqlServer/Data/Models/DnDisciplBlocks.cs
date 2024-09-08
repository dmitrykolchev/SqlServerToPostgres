using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class DnDisciplBlocks
{
    public long Id { get; set; }

    public long? BlockId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? DisciplId { get; set; }
}
