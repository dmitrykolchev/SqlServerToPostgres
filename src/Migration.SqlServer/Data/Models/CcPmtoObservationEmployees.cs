using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcPmtoObservationEmployees
{
    public long Id { get; set; }

    public long? Observation { get; set; }

    public long? Collaborator { get; set; }

    public string? Fullname { get; set; }

    public string? Position { get; set; }

    public string? PositionShort { get; set; }

    public string? PositionFuture { get; set; }

    public bool? FlLeader { get; set; }

    public string? SubdivisionCeh { get; set; }

    public string? Description { get; set; }

    public long? Number { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
