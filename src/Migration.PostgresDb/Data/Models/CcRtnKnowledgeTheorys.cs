using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcRtnKnowledgeTheorys
{
    public long Id { get; set; }

    public long? ApplicationId { get; set; }

    public DateTime? Date { get; set; }

    public long? ResultId { get; set; }

    public string? Note { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
