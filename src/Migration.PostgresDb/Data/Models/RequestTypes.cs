using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class RequestTypes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectQueryQual { get; set; }

    public bool? IsGroup { get; set; }

    public bool? ForbidRejection { get; set; }

    public long? WorkflowId { get; set; }

    public string? AccessBlockType { get; set; }

    public long? RemoteActionId { get; set; }

    public List<long>? RoleId { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
