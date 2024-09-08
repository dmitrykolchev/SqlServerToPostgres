﻿using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcSkvzCouncilMemberDivs
{
    public long Id { get; set; }

    public long? CouncilMemberId { get; set; }

    public long? DivId { get; set; }

    public long? CuratorId { get; set; }

    public long? ActivityId { get; set; }

    public string? Code { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
