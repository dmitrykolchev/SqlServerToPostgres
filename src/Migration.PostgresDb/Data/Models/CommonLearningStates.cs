using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonLearningStates
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? ShortDescriptor { get; set; }

    public string? LongDescriptor { get; set; }

    public string? TextColor { get; set; }

    public string? LpeColor { get; set; }
}
