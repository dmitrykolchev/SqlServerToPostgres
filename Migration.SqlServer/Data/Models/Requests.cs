using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Requests
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Type { get; set; }

    public long? RequestTypeId { get; set; }

    public string? StatusId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonOrgName { get; set; }

    public bool? IsGroup { get; set; }

    public long? PersonNum { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public long? BudgetPeriodId { get; set; }

    public long? WorkflowId { get; set; }

    public string? WorkflowState { get; set; }

    public string? WorkflowStateName { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? CloseDate { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? TagId { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }
}
