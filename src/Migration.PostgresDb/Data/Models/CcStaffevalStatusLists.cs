using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcStaffevalStatusLists
{
    public long Id { get; set; }

    public string? StatusId { get; set; }

    public string? StatusName { get; set; }

    public string? Type { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
