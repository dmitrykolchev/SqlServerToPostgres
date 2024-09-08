using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class EventObjectResources
{
    public long Id { get; set; }

    public long? EventId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? TypeId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? StatusId { get; set; }

    public long? PersonNum { get; set; }

    public long? PlaceId { get; set; }

    public long? ObjectResourceId { get; set; }

    public string? ObjectResourceName { get; set; }

    public string? ObjectResourceType { get; set; }
}
