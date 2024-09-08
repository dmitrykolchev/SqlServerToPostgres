﻿using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcScmtAssignAnswers
{
    public long Id { get; set; }

    public long? GroupUserRel { get; set; }

    public short? Type { get; set; }

    public long? Answer { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
