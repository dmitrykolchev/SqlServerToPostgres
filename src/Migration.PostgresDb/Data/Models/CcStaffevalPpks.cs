using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcStaffevalPpks
{
    public long Id { get; set; }

    public string? CreatedBy { get; set; }

    public long? PpkCaId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Requisites { get; set; }

    public string? SpResponsibleDev { get; set; }

    public string? PositionsName { get; set; }

    public string? SpForPpk { get; set; }

    public string? Category1 { get; set; }

    public string? Category2 { get; set; }

    public short? Rostehnadzor { get; set; }

    public string? SpReponsibleSupport { get; set; }

    public long? FioResponsible { get; set; }

    public long? StartYear { get; set; }

    public long? EndYear { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? PpkLocation { get; set; }

    public long? TheoreticalHours { get; set; }

    public long? PracticalHours { get; set; }

    public long? InternshipHours { get; set; }

    public long? InstructionHours { get; set; }

    public long? TrainingHours { get; set; }

    public long? CreatorId { get; set; }

    public string? StatusId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public short? AnketIsSend { get; set; }

    public DateTime? AnketSendDate { get; set; }

    public long? AnketIsOverdue { get; set; }

    public DateTime? AnketIsOverdueSendDate { get; set; }
}
