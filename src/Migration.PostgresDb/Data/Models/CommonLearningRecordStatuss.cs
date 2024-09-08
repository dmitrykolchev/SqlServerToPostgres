using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonLearningRecordStatuss
{
    public string Id { get; set; } = null!;

    public string? IconUrl { get; set; }

    public string? Name { get; set; }
}
