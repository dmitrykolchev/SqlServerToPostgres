using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class KnowledgeAcquaints
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? KnowledgePartId { get; set; }

    public string? KnowledgePartName { get; set; }

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

    public string? LevelId { get; set; }

    public long? LevelIndex { get; set; }

    public string? LevelName { get; set; }

    public string? SecObjectType { get; set; }

    public long? SecObjectId { get; set; }

    public string? SecObjectName { get; set; }

    public string? StateId { get; set; }

    public string? TypeId { get; set; }

    public DateTime? ConfirmationDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? ConfirmationType { get; set; }

    public string? ConfirmationExpertType { get; set; }

    public long? ConfirmationBossTypeId { get; set; }

    public long? ProjectParticipantId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
