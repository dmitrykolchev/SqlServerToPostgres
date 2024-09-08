using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class KpiProfiles
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? CompetenceProfileFamilyId { get; set; }

    public List<long>? RoleId { get; set; }

    public long? ParentKpiProfileId { get; set; }

    public List<long>? KpiId { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }

    public long? WorkflowId { get; set; }

    public string? WorkflowState { get; set; }

    public string? WorkflowStateName { get; set; }

    public List<long>? WorkflowPersonId { get; set; }

    public string? WorkflowMatchingType { get; set; }

    public List<long>? WorkflowMainPersonId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
