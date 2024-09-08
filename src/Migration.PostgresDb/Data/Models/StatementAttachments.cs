using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class StatementAttachments
{
    public long Id { get; set; }

    public string? Path { get; set; }

    public string? UsageType { get; set; }

    public string? ContentType { get; set; }

    public string? Length { get; set; }

    public string? FileHash { get; set; }

    public string? FileUrl { get; set; }

    public long? StatementId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
