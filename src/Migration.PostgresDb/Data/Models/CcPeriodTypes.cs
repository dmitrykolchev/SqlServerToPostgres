﻿using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcPeriodTypes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? ChangeCode { get; set; }

    public short? SpAccess { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public short? UnplanAccess { get; set; }
}
