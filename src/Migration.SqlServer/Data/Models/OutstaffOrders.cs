using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class OutstaffOrders
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? BudgetPeriodId { get; set; }

    public long? SubdivisionId { get; set; }

    public long? PositionCommonId { get; set; }

    public long? RegionId { get; set; }

    public long? AgreementPersonId { get; set; }

    public double? CostHour { get; set; }

    public double? CostSum { get; set; }

    public DateTime? FormedDate { get; set; }

    public DateTime? PaidDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
