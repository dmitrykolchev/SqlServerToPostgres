using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class PersonnelReserves
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public long? CareerReserveTypeId { get; set; }

    public long? ExclusionReasonId { get; set; }

    public long? NominationId { get; set; }

    public long? DevelopmentPotentialId { get; set; }

    public long? EfficiencyEstimationId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonPositionName { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? IncludeReserveDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
