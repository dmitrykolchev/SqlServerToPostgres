using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class RecommenderAlgorithms
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public bool? IsEnabled { get; set; }

    public string? TriggerType { get; set; }

    public long? Period { get; set; }

    public string? StartTime { get; set; }

    public string? FinishTime { get; set; }

    public bool? AllDay { get; set; }

    public long? StartDay { get; set; }

    public long? StartWeekDay { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public DateTime? LastRunDate { get; set; }

    public long? CodeLibraryId { get; set; }

    public bool? IsCurUser { get; set; }

    public bool? IsObjectType { get; set; }

    public bool? UseCache { get; set; }

    public long? CacheTime { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
