using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CareerReserves
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonPosition { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? PlanReadinessDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public long? ReadinessPercent { get; set; }

    public long? PersonnelReserveId { get; set; }

    public string? PositionType { get; set; }

    public string? PositionName { get; set; }

    public long? PositionId { get; set; }

    public long? PositionCommonId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
