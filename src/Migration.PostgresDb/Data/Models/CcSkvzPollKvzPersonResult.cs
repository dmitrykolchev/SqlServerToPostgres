using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcSkvzPollKvzPersonResult
{
    public long Id { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Modified { get; set; }

    public DateTime Ftime { get; set; }

    public string? Data { get; set; }

    public virtual SpxmlObjects IdNavigation { get; set; } = null!;
}
