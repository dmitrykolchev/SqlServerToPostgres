﻿using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Workflows
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? ConditionEvalStr { get; set; }

    public string? EscalationStagesStr { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public bool? UseTriggers { get; set; }

    public bool? IsStd { get; set; }

    public string? RoleId { get; set; }
}
