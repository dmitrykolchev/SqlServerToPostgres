using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class DownloadPackages
{
    public long Id { get; set; }

    public string? PackageId { get; set; }

    public long? ExchangeServerId { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public DateTime? PackageDate { get; set; }

    public DateTime? CreateDate { get; set; }
}
