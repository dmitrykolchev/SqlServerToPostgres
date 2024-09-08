using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class WikiArticleTypes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }
}
