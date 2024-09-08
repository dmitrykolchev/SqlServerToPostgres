using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Activity
{
    public long Id { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Modified { get; set; }

    public string? Data { get; set; }

    public virtual SpxmlObjects IdNavigation { get; set; } = null!;
}
