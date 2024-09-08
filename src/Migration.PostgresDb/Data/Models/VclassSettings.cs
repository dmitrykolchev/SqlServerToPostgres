using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class VclassSettings
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? EventId { get; set; }

    public long? ConversationId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
