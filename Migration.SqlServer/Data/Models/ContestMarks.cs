using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class ContestMarks
{
    public long Id { get; set; }

    public long? ContestId { get; set; }

    public string? ContestName { get; set; }

    public long? ParticipantId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonPositionName { get; set; }

    public string? StatusId { get; set; }

    public string? GeneralMark { get; set; }

    public long? JudgeId { get; set; }

    public string? Value { get; set; }

    public double? Rating { get; set; }

    public long? Place { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
