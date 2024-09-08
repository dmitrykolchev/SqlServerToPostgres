using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Positions
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? OrgId { get; set; }

    public long? ParentObjectId { get; set; }

    public long? BasicCollaboratorId { get; set; }

    public string? BasicCollaboratorFullname { get; set; }

    public long? BasicRate { get; set; }

    public bool? IsBoss { get; set; }

    public DateTime? PositionDate { get; set; }

    public long? CompetenceProfileId { get; set; }

    public long? KpiProfileId { get; set; }

    public long? KnowledgeProfileId { get; set; }

    public long? PositionCommonId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public DateTime? PositionFinishDate { get; set; }

    public bool? IsPositionFinished { get; set; }

    public string? PositionAssignmentType { get; set; }

    public long? BonusProfileId { get; set; }
}
