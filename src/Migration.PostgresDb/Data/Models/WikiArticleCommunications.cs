using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class WikiArticleCommunications
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public long? WikiArticleCommTypeId { get; set; }

    public long? BaseWikiArticleId { get; set; }

    public long? ChildWikiArticleId { get; set; }

    public long? Position { get; set; }

    public DateTime? ModificationDate { get; set; }
}
