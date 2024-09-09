using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Providers
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public bool? ProviderProduct { get; set; }

    public string? RoleId { get; set; }

    public long? DimensionId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
