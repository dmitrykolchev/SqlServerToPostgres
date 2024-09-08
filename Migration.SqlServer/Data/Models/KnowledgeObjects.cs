using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class KnowledgeObjects
{
    public long Id { get; set; }

    public string? Catalog { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public string? ObjectStatus { get; set; }

    public DateTime? ObjectStartDate { get; set; }

    public DateTime? ObjectEndDate { get; set; }

    public long? KnowledgePartId { get; set; }

    public string? KnowledgePartName { get; set; }

    public bool? RequireAcknowledgement { get; set; }

    public DateTime? DocCreateDate { get; set; }

    public long? KnowledgePartLevelId { get; set; }
}
