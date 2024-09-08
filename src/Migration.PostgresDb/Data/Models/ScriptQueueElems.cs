using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ScriptQueueElems
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? FinishTime { get; set; }

    public long? Delay { get; set; }

    public bool? Completed { get; set; }

    public bool? DeleteAutomatically { get; set; }

    public string? Block { get; set; }

    public List<long>? RoleId { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
