using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class BlogEntrys
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public DateTime? CreateDate { get; set; }

    public bool? AllowComment { get; set; }

    public bool? Blocked { get; set; }

    public string? Labels { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? BlogId { get; set; }

    public string? FeedItemId { get; set; }

    public long? ObjectId { get; set; }

    public long? CommentNum { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }

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

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
