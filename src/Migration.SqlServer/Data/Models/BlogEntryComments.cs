using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class BlogEntryComments
{
    public long Id { get; set; }

    public DateTime? CreateDate { get; set; }

    public long? BlogEntryId { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectName { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? CreatorName { get; set; }

    public string? Message { get; set; }

    public long? ParentId { get; set; }

    public long? LikeId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
