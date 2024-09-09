using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Participants
{
    public long Id { get; set; }

    public string? WorkName { get; set; }

    public long? ContestId { get; set; }

    public string? ContestName { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonPositionName { get; set; }

    public string? PersonOrgName { get; set; }

    public string? PersonSubdivisionName { get; set; }

    public string? PersonInstanceId { get; set; }

    public string? PersonCode { get; set; }

    public double? Rating { get; set; }

    public long? Place { get; set; }

    public string? StatusId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public long? PersonPositionId { get; set; }

    public string? PersonPositionCode { get; set; }

    public long? PersonOrgId { get; set; }

    public string? PersonOrgCode { get; set; }

    public long? PersonSubdivisionId { get; set; }

    public string? PersonSubdivisionCode { get; set; }
}
