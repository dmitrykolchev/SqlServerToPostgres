using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class PersonMessages
{
    public long Id { get; set; }

    public string? Type { get; set; }

    public long? ObjectId { get; set; }

    public long? BlockMessageId { get; set; }

    public long? PersonId { get; set; }

    public string? ConversationState { get; set; }

    public string? Role { get; set; }

    public string? MessageId { get; set; }

    public string? MessageText { get; set; }

    public DateTime? MessageDate { get; set; }

    public long? FileCount { get; set; }

    public bool? Unread { get; set; }
}
