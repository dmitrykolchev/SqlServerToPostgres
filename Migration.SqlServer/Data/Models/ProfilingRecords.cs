using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class ProfilingRecords
{
    public long Id { get; set; }

    public DateTime? StartDate { get; set; }

    public long? Ticks { get; set; }

    public string? Url { get; set; }

    public string? Sid { get; set; }

    public long? Duration { get; set; }

    public string? TemplateType { get; set; }

    public long? TemplateId { get; set; }

    public string? ParentTemplateType { get; set; }

    public long? ParentTemplateId { get; set; }
}
