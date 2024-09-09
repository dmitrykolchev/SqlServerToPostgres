using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class OrderTypes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Number { get; set; }

    public string? Prefix { get; set; }

    public string? Suffix { get; set; }

    public string? SigningPersonFullname { get; set; }

    public string? ResponsiblePersonFullname { get; set; }

    public string? PerformerPersonFullname { get; set; }

    public bool? DefaultFlag { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
