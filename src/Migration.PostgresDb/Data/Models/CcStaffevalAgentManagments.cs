using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcStaffevalAgentManagments
{
    public long Id { get; set; }

    public long? AgentLink { get; set; }

    public string? TriggerType { get; set; }

    public long? Period { get; set; }

    public string? AgentName { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
