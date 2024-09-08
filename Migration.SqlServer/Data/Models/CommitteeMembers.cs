using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CommitteeMembers
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Catalog { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public long? BossTypeId { get; set; }

    public long? PersonnelCommitteeId { get; set; }

    public string? Status { get; set; }

    public string? CommitteeMemberType { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
