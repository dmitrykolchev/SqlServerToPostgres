﻿using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcPfoMethodResults
{
    public long Id { get; set; }

    public long? PersonId { get; set; }

    public long? MethodId { get; set; }

    public DateTime? TestDate { get; set; }

    public long? ActiveLearningId { get; set; }

    public short? AddManually { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
