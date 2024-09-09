using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Payments
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public DateTime? PayDate { get; set; }

    public double? Sum { get; set; }

    public string? CurrencyTypeId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? BudgetPeriodId { get; set; }

    public long? PaymentTypeId { get; set; }

    public long? BudgetId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
