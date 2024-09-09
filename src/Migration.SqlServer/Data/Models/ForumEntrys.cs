using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class ForumEntrys
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public bool? Closed { get; set; }

    public bool? Pinned { get; set; }

    public string? How2show { get; set; }

    public string? AuthorInfo { get; set; }

    public long? UserId { get; set; }

    public string? PersonFullname { get; set; }

    public long? ForumId { get; set; }

    public long? ParentForumEntryId { get; set; }

    public long? MainForumEntryId { get; set; }

    public bool? IsModerApproved { get; set; }

    public DateTime? LastCreateDate { get; set; }

    public long? ChildNum { get; set; }

    public string? RemoteIp { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
