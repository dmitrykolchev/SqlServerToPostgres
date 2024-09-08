using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Knowledges
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public long? KnowledgeClassifierId { get; set; }

    public long? ParentObjectId { get; set; }

    public string? ParentCatalog { get; set; }

    public bool? HasExperts { get; set; }
}
