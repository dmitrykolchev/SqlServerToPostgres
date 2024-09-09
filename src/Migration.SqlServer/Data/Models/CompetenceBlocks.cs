using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CompetenceBlocks
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ParentObjectId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
