using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class PersonalChats
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? ChatId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public bool? Confirmed { get; set; }

    public bool? Prohibited { get; set; }

    public long? PartnerId { get; set; }

    public string? PartnerFullname { get; set; }

    public bool? PartnerConfirmed { get; set; }

    public bool? PartnerProhibited { get; set; }

    public DateTime? LastMessageDate { get; set; }

    public DateTime? LastViewDate { get; set; }

    public string? LastMessageText { get; set; }

    public long? LastMessageSenderId { get; set; }

    public DateTime? ModificationDate { get; set; }
}
