using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CommonConversationObjectTypes
{
    public string ObjectType { get; set; } = null!;

    public bool? IsFixParticipants { get; set; }

    public bool? ExcludeChannelParticipant { get; set; }
}
