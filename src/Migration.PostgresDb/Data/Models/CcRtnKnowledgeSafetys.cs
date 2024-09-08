﻿using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcRtnKnowledgeSafetys
{
    public long Id { get; set; }

    public long? CollaboratorId { get; set; }

    public long? PostLicensedId { get; set; }

    public DateTime? PlanDate { get; set; }

    public DateTime? FactDate { get; set; }

    public long? ResultId { get; set; }

    public string? DocProps { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
