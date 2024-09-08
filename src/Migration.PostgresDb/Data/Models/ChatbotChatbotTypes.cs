using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ChatbotChatbotTypes
{
    public long Id { get; set; }

    public string? ChatbotCode { get; set; }

    public string? BotId { get; set; }

    public long? ChatbotId { get; set; }

    public long? ChatbotTypeId { get; set; }

    public string? WebhookUrl { get; set; }
}
