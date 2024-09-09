using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Tasks
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ParentTaskId { get; set; }

    public long? TranslatedTaskId { get; set; }

    public string? TranslatedTargetType { get; set; }

    public long? TranslatedTargetId { get; set; }

    public long? AssignerId { get; set; }

    public string? ExecutorType { get; set; }

    public long? ExecutorId { get; set; }

    public string? Status { get; set; }

    public double? Value { get; set; }

    public string? SourceObjectType { get; set; }

    public long? SourceObjectId { get; set; }

    public string? TargetObjectType { get; set; }

    public long? TargetObjectId { get; set; }

    public string? FactObjectType { get; set; }

    public long? FactObjectId { get; set; }

    public string? ExpertId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public long? TaskTypeId { get; set; }

    public DateTime? DatePlan { get; set; }

    public DateTime? DateFact { get; set; }

    public DateTime? StartDatePlan { get; set; }

    public DateTime? EndDatePlan { get; set; }

    public string? RoleId { get; set; }
}
