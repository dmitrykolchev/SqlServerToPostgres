using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class EducationPlans
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? GroupId { get; set; }

    public long? CompoundProgramId { get; set; }

    public string? Type { get; set; }

    public long? PersonId { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonOrgName { get; set; }

    public long? EventId { get; set; }

    public bool? UpdateStatusAndActivity { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public DateTime? FactFinishDate { get; set; }

    public DateTime? PlanDate { get; set; }

    public DateTime? LastActivityDate { get; set; }

    public long? Mark { get; set; }

    public long? StateId { get; set; }

    public long? ReadinessPercent { get; set; }

    public long? DevelopmentPlanId { get; set; }

    public long? BudgetPeriodId { get; set; }

    public long? AssessmentAppraiseId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
