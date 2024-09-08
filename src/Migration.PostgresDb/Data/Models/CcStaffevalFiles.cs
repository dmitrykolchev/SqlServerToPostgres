using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcStaffevalFiles
{
    public long Id { get; set; }

    public string? Type { get; set; }

    public long? FileId { get; set; }

    public string? FileName { get; set; }

    public string? FileType { get; set; }

    public long? Period { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
