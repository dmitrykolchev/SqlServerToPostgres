using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Projects
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? OrgId { get; set; }

    public long? SubdivisionId { get; set; }

    public long? GroupId { get; set; }

    public long? ContractId { get; set; }

    public string? Status { get; set; }

    public bool? IsModel { get; set; }

    public DateTime? StartDatePlan { get; set; }

    public DateTime? EndDatePlan { get; set; }

    public DateTime? StartDateFact { get; set; }

    public DateTime? EndDateFact { get; set; }

    public string? JoinMode { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public long? ResourceTypeId { get; set; }

    public string? RoleId { get; set; }
}
