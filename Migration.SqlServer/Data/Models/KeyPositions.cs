using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class KeyPositions
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? PositionId { get; set; }

    public string? PositionName { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonCode { get; set; }

    public long? RiskPerspectiveId { get; set; }

    public string? RiskLevels { get; set; }

    public long? KeyPositionThreatId { get; set; }

    public long? CareerReserveTypeId { get; set; }

    public string? Status { get; set; }

    public bool? IsOpen { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public long? BudgetPeriodId { get; set; }
}
