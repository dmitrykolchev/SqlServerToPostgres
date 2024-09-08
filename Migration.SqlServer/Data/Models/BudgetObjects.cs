using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class BudgetObjects
{
    public long Id { get; set; }

    public long? BudgetId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? CatalogName { get; set; }

    public bool? All { get; set; }

    public long? ObjectId { get; set; }
}
