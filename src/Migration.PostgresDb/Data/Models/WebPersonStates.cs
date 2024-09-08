using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class WebPersonStates
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? TypeId { get; set; }
}
