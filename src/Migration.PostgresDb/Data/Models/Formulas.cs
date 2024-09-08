using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Formulas
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public string? Dependencies { get; set; }

    public string? FormulaEvalStr { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
