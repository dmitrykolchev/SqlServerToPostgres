using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class MobileAppConfigs
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public DateTime? ModificationDate { get; set; }
}
