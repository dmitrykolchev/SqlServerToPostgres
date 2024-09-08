using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class OutstaffOrderExecutions
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? CollaboratorFullname { get; set; }

    public long? PositionCommonId { get; set; }

    public string? PositionCommonName { get; set; }

    public long? SubdivisionId { get; set; }

    public string? SubdivisionName { get; set; }

    public long? BudgetPeriodId { get; set; }

    public long? OutstaffContractId { get; set; }

    public string? OutstaffContractName { get; set; }

    public DateTime? FormedDate { get; set; }

    public DateTime? PaidDate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
