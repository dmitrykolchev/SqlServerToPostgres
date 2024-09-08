using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class UploadPackages
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Type { get; set; }

    public string? FileUrl { get; set; }

    public DateTime? PackageDate { get; set; }

    public string? Comment { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
