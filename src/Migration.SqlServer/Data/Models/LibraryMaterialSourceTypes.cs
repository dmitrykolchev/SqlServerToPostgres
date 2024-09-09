using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class LibraryMaterialSourceTypes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public bool? IsActive { get; set; }

    public string? Filenamemask { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? Type { get; set; }

    public long? LibraryPlayerId { get; set; }
}
