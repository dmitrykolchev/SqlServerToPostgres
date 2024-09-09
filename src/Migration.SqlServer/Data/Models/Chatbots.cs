using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Chatbots
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? StartChatbotStageId { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? AppInstanceId { get; set; }
}
