using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ConversationTypes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? VisibleTypeId { get; set; }

    public bool? UseOpenScript { get; set; }

    public bool? UseAdditionalInfoScript { get; set; }

    public bool? ProhibitWrite { get; set; }

    public bool? CanCall { get; set; }

    public bool? CanChangeParticipant { get; set; }

    public bool? CanShowAdditionalInfo { get; set; }

    public bool? OpenAdditionalInfo { get; set; }

    public long? ChatbotId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
