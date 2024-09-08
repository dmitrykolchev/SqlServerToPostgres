using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class PersonActivityInfos
{
    public long Id { get; set; }

    public long? PersonId { get; set; }

    public DateTime? ChatLastActivityDate { get; set; }

    public long? PresenceStateId { get; set; }

    public DateTime? UpdateDate { get; set; }
}
