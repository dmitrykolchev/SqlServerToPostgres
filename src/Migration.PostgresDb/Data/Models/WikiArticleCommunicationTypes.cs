using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class WikiArticleCommunicationTypes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public string? WikiCommunicationTypeId { get; set; }

    public long? BaseWikiArticleTypeId { get; set; }

    public long? ChildWikiArticleTypeId { get; set; }

    public bool? IsMandatory { get; set; }

    public DateTime? ModificationDate { get; set; }
}
