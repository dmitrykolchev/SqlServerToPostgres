using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcScmtAssignGroupLists
{
    public long Id { get; set; }

    public long? Group { get; set; }

    public long? User { get; set; }

    public string? Shift { get; set; }

    public long? TimeQuestOne { get; set; }

    public long? TimeQuestTwo { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public short? FlForcedNull { get; set; }

    public string? Fullname { get; set; }

    public string? Position { get; set; }

    public string? SubdivisionCeh { get; set; }
}
