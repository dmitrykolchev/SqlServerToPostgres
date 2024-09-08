using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ProjectParticipants
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Catalog { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? PersonPositionId { get; set; }

    public string? PersonPositionName { get; set; }

    public string? PersonPositionCode { get; set; }

    public long? PersonOrgId { get; set; }

    public string? PersonOrgName { get; set; }

    public string? PersonOrgCode { get; set; }

    public long? PersonSubdivisionId { get; set; }

    public string? PersonSubdivisionName { get; set; }

    public string? PersonSubdivisionCode { get; set; }

    public string? PersonInstanceId { get; set; }

    public string? PersonCode { get; set; }

    public long? BossTypeId { get; set; }

    public long? ProjectId { get; set; }

    public List<long>? ParticipantRolesId { get; set; }

    public bool? IsExcluded { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public long? PlanLoad { get; set; }

    public long? PercentPlanLoad { get; set; }

    public string? StatusId { get; set; }

    public long? WorkflowId { get; set; }

    public string? WorkflowState { get; set; }

    public string? WorkflowStateName { get; set; }

    public List<long>? WorkflowPersonId { get; set; }

    public string? WorkflowMatchingType { get; set; }

    public string? Experts { get; set; }

    public string? Tags { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
