using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcWebNotifications
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public long? PersonId { get; set; }

    public bool? IsRead { get; set; }

    public bool? Toasted { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
