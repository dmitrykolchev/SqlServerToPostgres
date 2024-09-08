using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcStaffevalPollProcedures
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? PollId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? Comment { get; set; }

    public string? Status { get; set; }

    public long? CreatorId { get; set; }

    public long? StationId { get; set; }

    public long? BpId { get; set; }

    public long? PollProcessId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
