using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcSkvzPollKvzPersonResults
{
    public long Id { get; set; }

    public long? PersonId { get; set; }

    public string? SkvzActivity { get; set; }

    public string? KvzPersonArea { get; set; }

    public string? PersonType { get; set; }

    public long? PollResultId { get; set; }

    public long? DivId { get; set; }

    public long? Frod { get; set; }

    public long? FrodResultId { get; set; }

    public long? Fkd { get; set; }

    public long? Fdz { get; set; }

    public long? FkdFdzResultId { get; set; }

    public long? Fnpr { get; set; }

    public long? FnprResultId { get; set; }

    public double? Sfr { get; set; }

    public string? Code { get; set; }

    public bool? UtpApproved { get; set; }

    public long? StationBlockId { get; set; }

    public bool? IsUnplan { get; set; }

    public bool? IsHistory { get; set; }

    public long? BpId { get; set; }

    public bool? UnplanComplete { get; set; }

    public long? ProfileResultId { get; set; }

    public long? SuccessorsResultId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public long? MovedTo { get; set; }

    public long? MovedStage { get; set; }

    public long? MovedMentoringTo { get; set; }

    public long? MovedMentoringStage { get; set; }

    public long? MapSmallId { get; set; }

    public long? MapBigId { get; set; }
}
