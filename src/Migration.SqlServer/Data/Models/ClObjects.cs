using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class ClObjects
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Category { get; set; }

    public string? CategoryLabel { get; set; }

    public string? ResourceUrl { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }
}
