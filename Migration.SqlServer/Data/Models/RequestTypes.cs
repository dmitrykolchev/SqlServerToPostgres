using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class RequestTypes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? ObjectType { get; set; }

    public bool? IsGroup { get; set; }

    public string? AccessBlockType { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? RoleId { get; set; }

    public bool? IsStd { get; set; }
}
