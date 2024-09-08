using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class IndProgPassLog
{
    public long ProgramId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool IsChecked { get; set; }

    public long UpdateUser { get; set; }

    public DateTime? CheckedDate { get; set; }

    public bool IsPass { get; set; }
}
