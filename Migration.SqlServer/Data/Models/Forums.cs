using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Forums
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public bool? PermitSubscription { get; set; }

    public bool? Closed { get; set; }

    public bool? AllowAnonymousMessage { get; set; }

    public bool? AllowCreateClosedTheme { get; set; }

    public bool? AllowUserDelete { get; set; }

    public bool? DispUserStatus { get; set; }

    public long? CourseId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? RoleId { get; set; }
}
