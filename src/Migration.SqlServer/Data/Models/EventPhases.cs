using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class EventPhases
{
    public long Id { get; set; }

    public long? EventId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? TypeId { get; set; }

    public string? StatusId { get; set; }

    public bool? IsPublic { get; set; }

    public bool? IsOpen { get; set; }

    public long? PlaceId { get; set; }

    public long? LectorId { get; set; }

    public string? PersonFullname { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public long? ObjectResourceId { get; set; }
}
