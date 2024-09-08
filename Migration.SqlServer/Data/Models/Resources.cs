using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Resources
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public bool? AllowDownload { get; set; }

    public string? Comment { get; set; }

    public long? UseCount { get; set; }

    public string? FileName { get; set; }

    public long? Size { get; set; }

    public string? RoleId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public long? ResourceTypeId { get; set; }

    public string? Status { get; set; }

    public long? ResourceId { get; set; }

    public bool? AllowSearch { get; set; }

    public string? FilePath { get; set; }

    public string? Checksum { get; set; }

    public bool? EnableAnonymousAccess { get; set; }

    public long? AccessLevel { get; set; }

    public string? AccessRoles { get; set; }

    public string? AccessGroups { get; set; }

    public long? AccessOrgId { get; set; }

    public long? AccessSiteId { get; set; }

    public long? AccessHostId { get; set; }

    public string? Operator { get; set; }

    public string? Conditions { get; set; }
}
