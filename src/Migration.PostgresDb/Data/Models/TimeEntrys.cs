using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class TimeEntrys
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public long? OrgId { get; set; }

    public long? TaskId { get; set; }

    public string? TaskName { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public long? Duration { get; set; }

    public string? Description { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
