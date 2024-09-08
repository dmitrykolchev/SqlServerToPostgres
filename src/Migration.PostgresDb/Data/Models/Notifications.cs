using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Notifications
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public bool? Active { get; set; }

    public bool? ActiveChatbotScript { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }

    public long? ChatbotId { get; set; }

    public List<long>? RoleId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
