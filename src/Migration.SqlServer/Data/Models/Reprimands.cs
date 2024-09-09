using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Reprimands
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ReprimandTypeId { get; set; }

    public long? PersonId { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? ModificationDate { get; set; }
}
