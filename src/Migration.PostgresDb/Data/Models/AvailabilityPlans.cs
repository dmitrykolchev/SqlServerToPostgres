using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class AvailabilityPlans
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? CatalogName { get; set; }

    public long? ObjectId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
