using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class UserRecommendations
{
    public long Id { get; set; }

    public string? ObjectType { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public long? ContextObjectId { get; set; }

    public string? ContextObjectType { get; set; }

    public string? ContextObjectName { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
