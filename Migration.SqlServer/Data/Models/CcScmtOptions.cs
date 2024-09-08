using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcScmtOptions
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Value { get; set; }

    public string? Description { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public long? Subdivision { get; set; }
}
