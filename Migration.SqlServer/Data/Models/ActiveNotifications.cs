using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class ActiveNotifications
{
    public long Id { get; set; }

    public long? NotificationId { get; set; }

    public long? ObjectId { get; set; }

    public string? Subject { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? LastSendDate { get; set; }

    public DateTime? SendDate { get; set; }

    public string? RecipientPersonId { get; set; }

    public bool? IsCustom { get; set; }

    public string? Status { get; set; }

    public long? SendCounter { get; set; }
}
