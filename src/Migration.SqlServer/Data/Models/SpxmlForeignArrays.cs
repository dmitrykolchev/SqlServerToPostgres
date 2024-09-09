using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class SpxmlForeignArrays
{
    public string Catalog { get; set; } = null!;

    public string CatalogElem { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string ForeignArray { get; set; } = null!;
}
