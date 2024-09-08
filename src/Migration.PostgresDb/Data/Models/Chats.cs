using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Chats
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public bool? IsPersonal { get; set; }

    public bool? IsMultiplayer { get; set; }

    public string? Collaborators { get; set; }

    public List<long>? ParticipantIds { get; set; }

    public long? ConversationId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
