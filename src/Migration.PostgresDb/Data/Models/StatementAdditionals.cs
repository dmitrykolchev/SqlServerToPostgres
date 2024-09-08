using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class StatementAdditionals
{
    public long Id { get; set; }

    public string? Path { get; set; }

    public string? Name { get; set; }

    public string? Value { get; set; }

    public long? StatementId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
