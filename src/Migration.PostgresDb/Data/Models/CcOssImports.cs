using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcOssImports
{
    public long Id { get; set; }

    public string? Session { get; set; }

    public DateTime? Date { get; set; }

    public long? PartsNum { get; set; }

    public long? Part { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
