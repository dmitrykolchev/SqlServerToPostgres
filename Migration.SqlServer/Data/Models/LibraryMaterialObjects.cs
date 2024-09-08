using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class LibraryMaterialObjects
{
    public long Id { get; set; }

    public long? LibraryMaterialId { get; set; }

    public string? LibraryMaterialName { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public string? ObjectCatalog { get; set; }
}
