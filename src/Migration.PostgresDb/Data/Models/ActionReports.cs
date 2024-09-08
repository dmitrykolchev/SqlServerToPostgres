using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ActionReports
{
    public long Id { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public bool? Completed { get; set; }

    public long? ExchangeServerId { get; set; }

    public long? ObjectId { get; set; }

    public string? DataFileUrl { get; set; }

    public DateTime? LastUploadDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
