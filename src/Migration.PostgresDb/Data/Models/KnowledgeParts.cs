using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class KnowledgeParts
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public long? ParentObjectId { get; set; }

    public long? KnowledgeClassifierId { get; set; }

    public string? Experts { get; set; }

    public bool? RequireAcknowledgement { get; set; }

    public long? PreviousVersionObjectId { get; set; }

    public string? StatusInKnowledgeMap { get; set; }

    public long? KnowledgePartTypeId { get; set; }

    public string? ConfirmationType { get; set; }

    public long? ExpertiseLevelIndex { get; set; }

    public string? Tags { get; set; }

    public string? KnowledgeParts1 { get; set; }

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

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
