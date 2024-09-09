using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class PollProcedures
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? PersonId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool? WebDisplay { get; set; }

    public long? Status { get; set; }

    public bool? IsModel { get; set; }

    public string? StrSubBossesIds { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public string? RoleId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? TriggerType { get; set; }
}
