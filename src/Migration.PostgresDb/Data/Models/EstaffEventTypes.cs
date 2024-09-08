using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class EstaffEventTypes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public string? EventTypeEstaffId { get; set; }

    public long? OrgId { get; set; }

    public long? RecruitmentSystemId { get; set; }

    public string? PositionCommons { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
