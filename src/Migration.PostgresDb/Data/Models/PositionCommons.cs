using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class PositionCommons
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public double? MinSalary { get; set; }

    public double? MaxSalary { get; set; }

    public string? Currency { get; set; }

    public string? PositionFamilys { get; set; }

    public bool? AllowOutstaff { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }

    public long? KpiProfileId { get; set; }

    public List<long>? KpiProfilesId { get; set; }

    public long? BonusProfileId { get; set; }

    public long? KnowledgeProfileId { get; set; }

    public List<long>? ParentPositionCommonId { get; set; }

    public List<long>? GradeIds { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public List<long>? RoleId { get; set; }
}
