using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ServerAgents
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? Type { get; set; }

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

    public string? Block { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }

    public List<long>? RoleId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
