using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcKnowledgeClassifiers
{
    public long Id { get; set; }

    public long? KnowledgeClassifierId { get; set; }

    public long? PersonId { get; set; }

    public string? Code { get; set; }

    public string? FileId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
