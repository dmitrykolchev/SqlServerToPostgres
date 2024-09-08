using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Goods
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? GoodTypeId { get; set; }

    public string? RoleId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? CostDesc { get; set; }
}
