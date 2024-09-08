using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Likes
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? TypeId { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectName { get; set; }

    public long? SecObjectId { get; set; }

    public string? SecObjectType { get; set; }

    public string? Reaction { get; set; }

    public string? MessageId { get; set; }

    public double? Weight { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
