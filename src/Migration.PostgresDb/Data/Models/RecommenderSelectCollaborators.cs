using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class RecommenderSelectCollaborators
{
    public long Id { get; set; }

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

    public long? RecommenderAlgorithmId { get; set; }

    public long? BaseObjectId { get; set; }

    public string? BaseObjectType { get; set; }

    public string? BaseObjectName { get; set; }

    public long? SelectedObjectId { get; set; }

    public string? SelectedObjectType { get; set; }

    public string? SelectedObjectName { get; set; }

    public long? CreatedObjectId { get; set; }

    public string? CreatedObjectType { get; set; }

    public string? CreatedObjectName { get; set; }

    public bool? Implemented { get; set; }

    public DateTime? SelectedDate { get; set; }

    public DateTime? ImplementedDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
