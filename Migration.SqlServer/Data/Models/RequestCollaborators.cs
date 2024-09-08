using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class RequestCollaborators
{
    public long Id { get; set; }

    public long? RequestId { get; set; }

    public string? Code { get; set; }

    public string? Type { get; set; }

    public long? RequestTypeId { get; set; }

    public string? StatusId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonOrgName { get; set; }

    public bool? IsGroup { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public long? WorkflowId { get; set; }

    public DateTime? CreateDate { get; set; }
}
