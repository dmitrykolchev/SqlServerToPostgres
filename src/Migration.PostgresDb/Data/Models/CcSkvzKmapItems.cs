using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcSkvzKmapItems
{
    public long Id { get; set; }

    public long? KmapId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Value { get; set; }

    public long? ParentId { get; set; }

    public long? BaseId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
