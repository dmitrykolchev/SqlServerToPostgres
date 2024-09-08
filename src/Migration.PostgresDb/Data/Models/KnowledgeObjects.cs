using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class KnowledgeObjects
{
    public long Id { get; set; }

    public string? Catalog { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public string? ObjectStatus { get; set; }

    public DateTime? ObjectStartDate { get; set; }

    public DateTime? ObjectEndDate { get; set; }

    public DateTime? DocCreateDate { get; set; }

    public long? KnowledgePartId { get; set; }

    public string? KnowledgePartName { get; set; }

    public string? CurrentLevelId { get; set; }

    public string? CurrentLevelName { get; set; }

    public long? CurrentLevelIndex { get; set; }

    public string? TargetLevelId { get; set; }

    public string? TargetLevelName { get; set; }

    public long? TargetLevelIndex { get; set; }

    public bool? RequireAcknowledgement { get; set; }

    public long? KnowledgePartLevelId { get; set; }

    public long? AcquaintTime { get; set; }
}
