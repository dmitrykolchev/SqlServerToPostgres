using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class EducationPlanCollaborators
{
    public long Id { get; set; }

    public long? ProgramId { get; set; }

    public long? ParentProgpamId { get; set; }

    public long? Position { get; set; }

    public long? EducationPlanId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? CompoundProgramId { get; set; }

    public long? EducationProgramId { get; set; }

    public long? EducationMethodId { get; set; }

    public long? DevelopmentPlanId { get; set; }

    public long? BudgetPeriodId { get; set; }

    public string? Type { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public string? ObjectCode { get; set; }

    public DateTime? ObjectStartDate { get; set; }

    public long? StateId { get; set; }

    public DateTime? PlanDate { get; set; }

    public string? ResultType { get; set; }

    public long? ResultObjectId { get; set; }

    public string? ResultObjectName { get; set; }

    public string? ResultObjectCode { get; set; }

    public DateTime? ResultObjectStartDate { get; set; }

    public DateTime? ResultObjectFinishDate { get; set; }

    public long? Weight { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public long? ReadinessPercent { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonPosition { get; set; }

    public string? PersonOrgName { get; set; }

    public string? PersonSubdivisionName { get; set; }

    public bool? IsCollaborator { get; set; }

    public bool? IsTutor { get; set; }
}
