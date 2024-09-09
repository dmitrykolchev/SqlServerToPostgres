using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class PayStages
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? SaleId { get; set; }

    public long? OrgId { get; set; }

    public long? ClientOrgId { get; set; }

    public long? SaleContractId { get; set; }

    public bool? IsPrepayment { get; set; }

    public long? MinCost { get; set; }

    public long? MaxCost { get; set; }

    public long? FactCost { get; set; }

    public string? CloseType { get; set; }

    public string? TypeId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
