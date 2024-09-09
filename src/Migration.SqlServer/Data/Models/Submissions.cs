using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Submissions
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? SubmissionTypeId { get; set; }

    public string? SubmissionTypeName { get; set; }

    public DateTime? PeriodDateStart { get; set; }

    public DateTime? PeriodDateFinish { get; set; }

    public string? PhaseName { get; set; }

    public long? PhaseId { get; set; }

    public string? StatusId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonPositionName { get; set; }

    public string? PersonOrgName { get; set; }

    public string? PersonSubdivisionName { get; set; }

    public string? PersonInstanceId { get; set; }

    public string? PersonCode { get; set; }

    public long? PersonPositionId { get; set; }

    public string? PersonPositionCode { get; set; }

    public long? PersonOrgId { get; set; }

    public string? PersonOrgCode { get; set; }

    public long? PersonSubdivisionId { get; set; }

    public string? PersonSubdivisionCode { get; set; }
}
