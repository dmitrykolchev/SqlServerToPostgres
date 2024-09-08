using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class LearningTaskResults
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? LearningTaskId { get; set; }

    public string? LearningTaskName { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? ExpertId { get; set; }

    public long? EventId { get; set; }

    public string? StatusId { get; set; }

    public long? Mark { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public DateTime? StartExecutionDate { get; set; }

    public DateTime? FinishExecutionDate { get; set; }

    public DateTime? PlanStartDate { get; set; }

    public DateTime? PlanEndDate { get; set; }

    public long? Duration { get; set; }

    public bool? Expired { get; set; }

    public long? EducationPlanId { get; set; }

    public long? ActiveLearningId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
