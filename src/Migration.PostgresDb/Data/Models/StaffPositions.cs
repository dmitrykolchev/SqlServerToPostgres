using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class StaffPositions
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? OrgName { get; set; }

    public long? OrgId { get; set; }

    public long? SubdivisionId { get; set; }

    public string? SubdivisionName { get; set; }

    public long? PositionCommonId { get; set; }

    public long? ProfessionId { get; set; }

    public long? ProfessionCategoryId { get; set; }

    public long? BonusProfileId { get; set; }

    public long? KpiProfileId { get; set; }

    public List<long>? KpiProfilesId { get; set; }

    public long? KnowledgeProfileId { get; set; }

    public long? CompetenceProfileId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public string? Tags { get; set; }

    public string? KnowledgeParts { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
