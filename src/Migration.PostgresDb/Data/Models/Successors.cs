using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Successors
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? KeyPositionId { get; set; }

    public long? KeyPersonId { get; set; }

    public string? KeyPersonFullname { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonPositionName { get; set; }

    public long? BudgetPeriodId { get; set; }

    public long? ReadinessLevelId { get; set; }

    public long? DevelopmentPotentialId { get; set; }

    public long? EfficiencyEstimationId { get; set; }

    public long? RequestId { get; set; }

    public string? Status { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
