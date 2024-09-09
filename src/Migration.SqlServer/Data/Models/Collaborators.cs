using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Collaborators
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Fullname { get; set; }

    public string? Login { get; set; }

    public string? ShortLogin { get; set; }

    public string? LowercaseLogin { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? Sex { get; set; }

    public string? PictUrl { get; set; }

    public long? PositionId { get; set; }

    public string? PositionName { get; set; }

    public long? PositionParentId { get; set; }

    public string? PositionParentName { get; set; }

    public long? OrgId { get; set; }

    public string? OrgName { get; set; }

    public string? CategoryId { get; set; }

    public bool? WebBanned { get; set; }

    public bool? IsArmAdmin { get; set; }

    public string? RoleId { get; set; }

    public bool? IsCandidate { get; set; }

    public bool? IsDismiss { get; set; }

    public DateTime? PositionDate { get; set; }

    public DateTime? HireDate { get; set; }

    public DateTime? DismissDate { get; set; }

    public bool? InRequestBlackList { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }

    public string? PersonObjectProfileId { get; set; }

    public string? CurrentState { get; set; }

    public long? DevelopmentPotentialId { get; set; }

    public long? EfficiencyEstimationId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public long? LevelId { get; set; }

    public string? MobilePhone { get; set; }

    public long? PlaceId { get; set; }

    public long? RegionId { get; set; }

    public bool? IsContentAdmin { get; set; }

    public long? CandidateStatusTypeId { get; set; }

    public bool? IsOutstaff { get; set; }
}
