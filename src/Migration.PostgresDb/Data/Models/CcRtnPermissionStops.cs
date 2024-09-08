﻿using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcRtnPermissionStops
{
    public long Id { get; set; }

    public long? PermissionId { get; set; }

    public DateTime? Date { get; set; }

    public string? DocProps { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
