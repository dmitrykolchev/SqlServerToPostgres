using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class ActiveTestLearnings
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? AssessmentId { get; set; }

    public string? AssessmentName { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonPositionName { get; set; }

    public string? PersonOrgName { get; set; }

    public string? PersonSubdivisionName { get; set; }

    public string? PersonInstanceId { get; set; }

    public string? PersonCurrentState { get; set; }

    public long? EventId { get; set; }

    public long? GroupId { get; set; }

    public DateTime? StartUsageDate { get; set; }

    public DateTime? StartLearningDate { get; set; }

    public DateTime? LastUsageDate { get; set; }

    public DateTime? MaxEndDate { get; set; }

    public double? Score { get; set; }

    public long? StateId { get; set; }

    public double? MaxScore { get; set; }

    public long? AssessmentAppraiseId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? CreationUserId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public long? ModificationUserId { get; set; }

    public string? AppInstanceId { get; set; }

    public long? Time { get; set; }

    public long? EducationPlanId { get; set; }

    public long? QuestionNum { get; set; }

    public long? QuestionAnsweredNum { get; set; }

    public long? QuestionPassedNum { get; set; }
}
