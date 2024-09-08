using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Polls
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public bool? IsMain { get; set; }

    public bool? Completed { get; set; }

    public bool? IsAnonymous { get; set; }

    public bool? IsOneTime { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public string? RoleId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }
}
