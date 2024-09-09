using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Documents
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ParentDocumentId { get; set; }

    public long? SiteId { get; set; }

    public string? Template { get; set; }

    public long? Position { get; set; }

    public bool? IsLink { get; set; }

    public string? LinkHref { get; set; }

    public string? LinkTarget { get; set; }

    public bool? PermitSubscription { get; set; }

    public bool? EnableAnonymousAccess { get; set; }

    public long? AccessLevel { get; set; }

    public string? AccessRoles { get; set; }

    public string? AccessGroups { get; set; }

    public string? Operator { get; set; }

    public string? Conditions { get; set; }

    public string? ParentObjectType { get; set; }

    public long? ParentObjectId { get; set; }

    public string? ParentObjectName { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public bool? Invariable { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public long? CustomTemplateType { get; set; }

    public long? AccessOrgId { get; set; }

    public long? AccessSiteId { get; set; }

    public long? AccessHostId { get; set; }

    public bool? AccessExists { get; set; }

    public string? CatalogListDesc { get; set; }

    public string? StatusInKnowledgeMap { get; set; }

    public DateTime? KpStartDate { get; set; }

    public DateTime? KpEndDate { get; set; }
}
