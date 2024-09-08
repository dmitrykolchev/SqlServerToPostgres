using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Qualifications
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? JoinMode { get; set; }

    public long? ParentId { get; set; }

    public string? Status { get; set; }

    public bool? YourselfStart { get; set; }

    public List<long>? QualificationId { get; set; }

    public long? LevelId { get; set; }

    public bool? IsReward { get; set; }

    public string? CurrencyTypeId { get; set; }

    public List<long>? RoleId { get; set; }

    public bool? EnableAnonymousAccess { get; set; }

    public long? AccessLevel { get; set; }

    public string? AccessRoles { get; set; }

    public string? AccessGroups { get; set; }

    public long? AccessOrgId { get; set; }

    public long? AccessSiteId { get; set; }

    public long? AccessHostId { get; set; }

    public long? WebModeId { get; set; }

    public string? Operator { get; set; }

    public string? Conditions { get; set; }

    public string? ConditionsQual { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
