using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class EventResults
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? EventId { get; set; }

    public string? EventName { get; set; }

    public DateTime? EventStartDate { get; set; }

    public string? StatusId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonPositionName { get; set; }

    public string? PersonOrgName { get; set; }

    public string? PersonSubdivisionName { get; set; }

    public long? RequestId { get; set; }

    public long? EventResultTypeId { get; set; }

    public bool? IsAssist { get; set; }

    public bool? IsConfirm { get; set; }

    public bool? IsBanned { get; set; }

    public bool? NotParticipate { get; set; }

    public bool? IsOpen { get; set; }

    public double? Score { get; set; }

    public DateTime? LastSendingDate { get; set; }

    public long? BudgetPeriodId { get; set; }

    public long? CostCenterId { get; set; }

    public bool? NotPay { get; set; }

    public bool? Guest { get; set; }

    public double? ExpenseSum { get; set; }

    public long? ObjectResourceId { get; set; }

    public long? CertificateId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
