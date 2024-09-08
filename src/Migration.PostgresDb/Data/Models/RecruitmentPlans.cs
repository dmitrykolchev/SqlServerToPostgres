using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class RecruitmentPlans
{
    public long Id { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public string? State { get; set; }

    public long? BudgetPeriodId { get; set; }

    public long? SubdivisionId { get; set; }

    public long? SubdivisionGroupId { get; set; }

    public long? PositionFamilyId { get; set; }

    public string? PositionType { get; set; }

    public long? PositionCommonId { get; set; }

    public string? PositionName { get; set; }

    public long? VacancyTypeId { get; set; }

    public long? Quantity { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
