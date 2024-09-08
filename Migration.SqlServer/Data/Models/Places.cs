using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Places
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ParentId { get; set; }

    public long? RegionId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public long? TimezoneId { get; set; }
}
