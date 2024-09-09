using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class ComponentPackages
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? DownloadPackageFileId { get; set; }

    public DateTime? DownloadDate { get; set; }

    public string? TypeId { get; set; }

    public bool? IsStd { get; set; }

    public DateTime? ComponentModificationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }
}
