using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ChatbotStages
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public long? ChatbotId { get; set; }

    public string? ActionType { get; set; }

    public string? KeyboardType { get; set; }

    public List<long>? RoleId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
