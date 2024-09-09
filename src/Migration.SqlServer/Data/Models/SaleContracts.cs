using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class SaleContracts
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? SaleId { get; set; }

    public long? OrgId { get; set; }

    public long? ClientOrgId { get; set; }

    public long? ParentSaleContractId { get; set; }

    public string? Number { get; set; }

    public string? SerialNumber { get; set; }

    public DateTime? DateSignature { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? CostCurrencyTypeId { get; set; }

    public long? CostValue { get; set; }

    public bool? ContractSigned { get; set; }

    public bool? AllActSigned { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
