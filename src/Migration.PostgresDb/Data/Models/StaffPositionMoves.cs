using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class StaffPositionMoves
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? SubdivisionId { get; set; }

    public string? SubdivisionName { get; set; }

    public long? PositionId { get; set; }

    public string? PositionName { get; set; }

    public DateTime? MoveDate { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
