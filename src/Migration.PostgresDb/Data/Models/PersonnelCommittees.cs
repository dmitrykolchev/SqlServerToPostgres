using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class PersonnelCommittees
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? OrgId { get; set; }

    public long? SubdivisionId { get; set; }

    public long? GroupId { get; set; }

    public long? CareerReserveTypeId { get; set; }

    public string? Status { get; set; }

    public string? ParticipantsStatus { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? CommitteeDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public List<long>? RoleId { get; set; }
}
