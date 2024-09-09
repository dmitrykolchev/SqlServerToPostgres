using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcEduThemes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public long? Duration { get; set; }

    public long? DefaultLector { get; set; }

    public long? Station { get; set; }

    public long? DefaultRoom { get; set; }

    public string? DefaultForm { get; set; }
}
