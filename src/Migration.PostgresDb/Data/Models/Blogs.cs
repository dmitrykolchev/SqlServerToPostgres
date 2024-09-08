using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Blogs
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public long? ChannelProviderId { get; set; }

    public bool? PermitSubscription { get; set; }

    public bool? AllowAnonymousComment { get; set; }

    public long? CreatorId { get; set; }

    public string? CreatorFullInfo { get; set; }

    public string? PersonFullname { get; set; }

    public long? PersonPositionId { get; set; }

    public string? PersonPositionName { get; set; }

    public string? PersonPositionCode { get; set; }

    public long? PersonOrgId { get; set; }

    public string? PersonOrgName { get; set; }

    public string? PersonOrgCode { get; set; }

    public long? PersonSubdivisionId { get; set; }

    public string? PersonSubdivisionName { get; set; }

    public string? PersonSubdivisionCode { get; set; }

    public string? PersonInstanceId { get; set; }

    public string? PersonCode { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectName { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public long? AuthorsNum { get; set; }

    public string? Authors { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }
}
