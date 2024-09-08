using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Vacancys
{
    public long Id { get; set; }

    public string? SourceId { get; set; }

    public string? Name { get; set; }

    public string? ProfessionAreaId { get; set; }

    public long? RegionId { get; set; }

    public string? EmploymentTypeId { get; set; }

    public string? EducTypeId { get; set; }

    public long? MinAge { get; set; }

    public long? MaxAge { get; set; }

    public long? MinWage { get; set; }

    public long? MaxWage { get; set; }

    public long? AvgWage { get; set; }

    public string? CurrencyTypeId { get; set; }

    public DateTime? PubDate { get; set; }

    public DateTime? EditDate { get; set; }

    public long? PubPeriod { get; set; }

    public bool? IsClosed { get; set; }

    public long? CollaboratorId { get; set; }

    public long? OrgId { get; set; }

    public string? OrgName { get; set; }

    public long? SubId { get; set; }

    public string? SubName { get; set; }

    public long? SiteId { get; set; }

    public string? Url { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public long? ProfessionId { get; set; }

    public string? ScheduleWorkId { get; set; }

    public long? ScheduleId { get; set; }

    public long? MinBudget { get; set; }

    public long? MaxBudget { get; set; }

    public string? BudgetCurrencyTypeId { get; set; }

    public long? PositionCommonId { get; set; }

    public string? Subordination { get; set; }

    public DateTime? CloseDate { get; set; }

    public long? RecruiterId { get; set; }
}
