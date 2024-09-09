using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcPfoPollProcedures
{
    public long Id { get; set; }

    public long? PfoPollId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public long? BpId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? QuestionsJson { get; set; }

    public string? Questions { get; set; }

    public string? State { get; set; }
}
