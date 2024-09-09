using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Levels
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? CurrencyTypeId { get; set; }

    public double? MinValue { get; set; }

    public double? MaxValue { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public long? PrevLevelId { get; set; }
}
