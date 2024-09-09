using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class ContractTypes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? CurrentNumber { get; set; }

    public string? Prefix { get; set; }

    public string? Suffix { get; set; }

    public bool? DefaultFlag { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
