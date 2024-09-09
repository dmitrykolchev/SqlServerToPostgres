using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class WikiArticles
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public long? WikiBaseId { get; set; }

    public long? WikiArticleTypeId { get; set; }

    public string? StatusId { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModificationDate { get; set; }
}
