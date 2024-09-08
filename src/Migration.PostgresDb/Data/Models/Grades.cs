using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Grades
{
    public long Id { get; set; }

    public long? Level { get; set; }

    public string? Name { get; set; }

    public string? Desc { get; set; }

    public DateTime? ModificationDate { get; set; }
}
