﻿using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Pas
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? AssessmentAppraiseId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonPositionName { get; set; }

    public long? ExpertPersonId { get; set; }

    public string? ExpertPersonFullname { get; set; }

    public string? ExpertPersonPositionName { get; set; }

    public string? CustomExperts { get; set; }

    public long? DepartmentId { get; set; }

    public string? DepartmentName { get; set; }

    public bool? FlagAppraiseDepartment { get; set; }

    public string? AssessmentAppraiseType { get; set; }

    public bool? IsDone { get; set; }

    public bool? IsReady { get; set; }

    public bool? IsFinal { get; set; }

    public string? Status { get; set; }

    public bool? FlagIsProcessed { get; set; }

    public double? Overall { get; set; }

    public DateTime? AppraiseDate { get; set; }

    public long? Index { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public long? AssessmentPlanId { get; set; }

    public long? CompetenceProfileId { get; set; }

    public long? KpiProfileId { get; set; }

    public long? BonusProfileId { get; set; }

    public long? BudgetPeriodId { get; set; }
}
