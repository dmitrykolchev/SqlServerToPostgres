using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class SectionInstructions
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Desc { get; set; }

    public long? ParentObjectId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
