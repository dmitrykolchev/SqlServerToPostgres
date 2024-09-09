using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Orders
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public double? Sum { get; set; }

    public string? CurrencyTypeId { get; set; }

    public DateTime? FormedDate { get; set; }

    public DateTime? PaidDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
