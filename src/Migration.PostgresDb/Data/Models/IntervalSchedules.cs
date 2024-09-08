using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class IntervalSchedules
{
    public long Id { get; set; }

    public string? Code { get; set; }

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

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public long? PresenceStateId { get; set; }

    public string? StatusId { get; set; }

    public DateTime? CreateDate { get; set; }

    public long? WorkflowId { get; set; }

    public string? WorkflowState { get; set; }

    public string? WorkflowStateName { get; set; }

    public string? WorkflowType { get; set; }

    public DateTime? ChangeStartDate { get; set; }

    public DateTime? ChangeFinishDate { get; set; }

    public List<long>? WorkflowPersonId { get; set; }

    public string? WorkflowMatchingType { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
