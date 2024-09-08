using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class EducationMethods
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public string? Type { get; set; }

    public string? StateId { get; set; }

    public long? EducationOrgId { get; set; }

    public long? CourseId { get; set; }

    public bool? IsOpen { get; set; }

    public double? Cost { get; set; }

    public double? CostNds { get; set; }

    public string? Currency { get; set; }

    public string? CostType { get; set; }

    public double? Duration { get; set; }

    public long? DurationDays { get; set; }

    public long? PersonNum { get; set; }

    public long? WorkflowId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }

    public string? EventForm { get; set; }

    public long? EventTypeId { get; set; }

    public List<long>? RoleId { get; set; }
}
