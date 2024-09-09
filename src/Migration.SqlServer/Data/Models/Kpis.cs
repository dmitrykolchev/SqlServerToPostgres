using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Kpis
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public bool? IsKpi { get; set; }

    public long? RangeMin { get; set; }

    public long? RangeMax { get; set; }

    public string? OwnersIds { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public string? RoleId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? AccessBlockType { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }
}
