using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class SocialEntrys
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? CatalogName { get; set; }

    public DateTime? CreateDate { get; set; }

    public long? ParentId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? ObjectType { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public long? LikeId { get; set; }

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
}
