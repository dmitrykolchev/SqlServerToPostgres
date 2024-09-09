using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CommonKnowledgePartsObjects
{
    public string KnowledgePartsObjectId { get; set; } = null!;

    public string? FormUrl { get; set; }

    public bool? IsFunctional { get; set; }
}
