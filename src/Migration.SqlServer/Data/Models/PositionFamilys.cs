using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class PositionFamilys
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }

    public long? SubdivisionGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public long? ParentPositionFamilyId { get; set; }
}
