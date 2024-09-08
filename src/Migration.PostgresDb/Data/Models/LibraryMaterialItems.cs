using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class LibraryMaterialItems
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? MaterialId { get; set; }

    public string? Number { get; set; }

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

    public long? FormatId { get; set; }

    public string? StateId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? IssueDate { get; set; }

    public DateTime? ReturnPlanDate { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? CreationUserId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public long? ModificationUserId { get; set; }

    public string? AppInstanceId { get; set; }
}
