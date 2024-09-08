using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ObjectLinks
{
    public long Id { get; set; }

    public string? ObjectType { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public long? RecommenderAlgorithmId { get; set; }

    public string? StateId { get; set; }

    public DateTime? CalcDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
