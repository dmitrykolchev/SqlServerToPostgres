using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class ChatbotStages
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public long? ChatbotId { get; set; }

    public string? ActionType { get; set; }

    public string? KeyboardType { get; set; }
}
