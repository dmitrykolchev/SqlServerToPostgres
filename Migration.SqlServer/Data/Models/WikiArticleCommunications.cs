using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class WikiArticleCommunications
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public long? WikiArticleCommunicationTypeId { get; set; }

    public long? BaseWikiArticleId { get; set; }

    public long? ChildWikiArticleId { get; set; }

    public DateTime? ModificationDate { get; set; }
}
