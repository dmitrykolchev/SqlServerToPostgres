using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Chatbots
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? StartChatbotStageId { get; set; }

    public string? Name { get; set; }

    public string? DispName { get; set; }

    public bool? IsEnabled { get; set; }

    public bool? CanCreateConversation { get; set; }

    public string? ObjectType { get; set; }

    public long? ResourceId { get; set; }

    public string? UsageObjectType { get; set; }

    public DateTime? ModificationDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public List<long>? RoleId { get; set; }

    public string? AppInstanceId { get; set; }
}
