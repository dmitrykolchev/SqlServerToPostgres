using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class KnowledgeProfiles
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? KnowledgeParts { get; set; }

    public long? ResourceId { get; set; }
}
