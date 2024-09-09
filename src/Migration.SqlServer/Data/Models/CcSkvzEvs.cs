using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcSkvzEvs
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public bool? NeedSuccessor { get; set; }

    public bool? NeedExtract { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
