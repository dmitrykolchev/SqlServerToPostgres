using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class SpxmlMetadata
{
    public string Schema { get; set; } = null!;

    public string Form { get; set; } = null!;

    public string? Tablename { get; set; }

    public string? Hash { get; set; }

    public bool? DocList { get; set; }

    public string? PrimaryKey { get; set; }

    public string? ParentIdElem { get; set; }

    public string? SpxmlForm { get; set; }

    public string? SpxmlFormElem { get; set; }

    public byte? SpxmlFormType { get; set; }

    public byte? SingleTenant { get; set; }

    public bool? FtIdx { get; set; }
}
