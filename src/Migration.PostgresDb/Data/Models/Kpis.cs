using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Kpis
{
    public long Id { get; set; }

    public long? ParentObjectId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public bool? IsKpi { get; set; }

    public long? KpiGroupId { get; set; }

    public long? RangeMin { get; set; }

    public long? RangeMax { get; set; }

    public string? OwnersIds { get; set; }

    public long? FormulaId { get; set; }

    public long? ScaleId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public List<long>? RoleId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? AccessBlockType { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }

    public long? PreviousVersionObjectId { get; set; }
}
