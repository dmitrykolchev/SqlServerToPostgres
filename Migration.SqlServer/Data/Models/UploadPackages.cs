using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class UploadPackages
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Type { get; set; }

    public string? FileUrl { get; set; }

    public DateTime? PackageDate { get; set; }

    public string? Comment { get; set; }
}
