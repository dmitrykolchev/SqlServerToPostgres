using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonExchangeObjectTypes
{
    public string Name { get; set; } = null!;

    public string? DispName { get; set; }

    public string? Title { get; set; }

    public string? WebTitle { get; set; }

    public string? WebTemplate { get; set; }

    public string? WebConst { get; set; }

    public bool? IsHier { get; set; }

    public bool? IsCustom { get; set; }

    public string? FormUrl { get; set; }

    public long? FormType { get; set; }

    public long? MaxRecordsNum { get; set; }

    public bool? FtIndex { get; set; }
}
