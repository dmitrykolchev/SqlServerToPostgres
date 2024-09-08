using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class BlockMessages
{
    public long Id { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? LastMessageDate { get; set; }

    public string? StateId { get; set; }

    public bool? AllMessageRead { get; set; }

    public long? CountMessage { get; set; }

    public string? ObjectType { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public bool? DisabledData { get; set; }

    public bool? HasLink { get; set; }

    public bool? HasFile { get; set; }

    public List<long>? RecipientId { get; set; }

    public List<long>? UnreadRecipientId { get; set; }

    public List<string>? DispRoleId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
