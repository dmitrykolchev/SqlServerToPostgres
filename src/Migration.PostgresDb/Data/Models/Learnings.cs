using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Learnings
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? CourseId { get; set; }

    public string? CourseName { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonPositionName { get; set; }

    public string? PersonOrgName { get; set; }

    public string? PersonSubdivisionName { get; set; }

    public string? PersonInstanceId { get; set; }

    public string? PersonCurrentState { get; set; }

    public long? EventId { get; set; }

    public string? EventName { get; set; }

    public DateTime? EventStartDate { get; set; }

    public long? GroupId { get; set; }

    public DateTime? StartUsageDate { get; set; }

    public DateTime? StartLearningDate { get; set; }

    public bool? IsSelfEnrolled { get; set; }

    public DateTime? LastUsageDate { get; set; }

    public DateTime? MaxEndDate { get; set; }

    public double? MaxScore { get; set; }

    public double? Score { get; set; }

    public string? TextResult { get; set; }

    public long? StateId { get; set; }

    public long? Time { get; set; }

    public long? EducationPlanId { get; set; }

    public long? ActiveLearningId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? CreationUserId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public long? ModificationUserId { get; set; }

    public string? AppInstanceId { get; set; }

    public bool? UseProctoring { get; set; }
}
