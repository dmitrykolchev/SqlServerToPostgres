using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Operations
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Category { get; set; }

    public long? OperationType { get; set; }

    public string? Action { get; set; }

    public string? OperationCatalogList { get; set; }

    public string? ObjectName { get; set; }

    public string? Group { get; set; }

    public bool? IsSystem { get; set; }

    public bool? UseAccessEval { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? RoleId { get; set; }
}
