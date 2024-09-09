using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcEditLogs
{
    public long Id { get; set; }

    public long? ObjectId { get; set; }

    public long? User { get; set; }

    public DateTime? Date { get; set; }

    public string? Action { get; set; }

    public string? OldData { get; set; }

    public string? NewData { get; set; }

    public string? Description { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
