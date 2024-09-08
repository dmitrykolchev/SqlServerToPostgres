using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcWebNotifications
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public long? PersonId { get; set; }

    public short? IsRead { get; set; }

    public short? Toasted { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
