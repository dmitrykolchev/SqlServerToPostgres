using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class ClCourses
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? AuthorId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public string? LocalizationId { get; set; }

    public string? TagId { get; set; }

    public string? RoleId { get; set; }

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
