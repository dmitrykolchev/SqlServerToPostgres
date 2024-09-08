using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class OutstaffOrderExecutionStages
{
    public long Id { get; set; }

    public long? OutstaffOrderExecutionId { get; set; }

    public string? Status { get; set; }

    public DateTime? FormedDate { get; set; }

    public long? PersonId { get; set; }

    public long? OutstaffProviderId { get; set; }

    public long? OutstaffContractId { get; set; }

    public long? OutstaffOrderId { get; set; }

    public long? SubdivisionId { get; set; }

    public long? BudgetPeriodId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public long? PositionCommonId { get; set; }

    public string? StageId { get; set; }

    public string? StageParentId { get; set; }

    public long? StageCollaboratorId { get; set; }

    public DateTime? StageDate { get; set; }

    public DateTime? StageFactDate { get; set; }

    public long? StageHourNum { get; set; }

    public long? StageHoursWorked { get; set; }

    public bool? StageIsAssist { get; set; }

    public string? StageStatusType { get; set; }
}
