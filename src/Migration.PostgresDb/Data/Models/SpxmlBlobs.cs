using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class SpxmlBlobs
{
    public string Url { get; set; } = null!;

    public byte[]? Data { get; set; }

    public string? Ext { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Modified { get; set; }

    public string? Hashdata { get; set; }

    public byte[]? Ftime { get; set; }
}
