﻿using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcRtnFaults
{
    public long Id { get; set; }

    public long? CollaboratorId { get; set; }

    public DateTime? Date { get; set; }

    public string? OrderProps { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
