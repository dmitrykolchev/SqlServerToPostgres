using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ActiveNotifications
{
    public long Id { get; set; }

    public long? NotificationId { get; set; }

    public long? ObjectId { get; set; }

    public string? Subject { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? LastSendDate { get; set; }

    public DateTime? SendDate { get; set; }

    public List<long>? RecipientPersonId { get; set; }

    public bool? IsCustom { get; set; }

    public string? Status { get; set; }

    public long? SendCounter { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
