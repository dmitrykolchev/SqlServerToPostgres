using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcRtnPostApproveds
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? CategoryId { get; set; }

    public long? SubcategoryId { get; set; }

    public bool? FlOperative { get; set; }

    public bool? FlActive { get; set; }

    public bool? FlLead { get; set; }

    public bool? FlCaControl { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
