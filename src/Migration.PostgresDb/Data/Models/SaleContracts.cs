using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class SaleContracts
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? StateId { get; set; }

    public bool? IsAgentContract { get; set; }

    public long? AgentOrgId { get; set; }

    public long? OrgId { get; set; }

    public long? ClientOrgId { get; set; }

    public long? ClientManagerId { get; set; }

    public long? ManagerId { get; set; }

    public long? ParentSaleContractId { get; set; }

    public string? Number { get; set; }

    public string? SerialNumber { get; set; }

    public DateTime? DateSignature { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? ClientLegal { get; set; }

    public string? ProviderLegal { get; set; }

    public string? ClientLegalName { get; set; }

    public string? ProviderLegalName { get; set; }

    public bool? BadDebt { get; set; }

    public double? ContractCost { get; set; }

    public string? CurrencyTypeId { get; set; }

    public string? ContractSignature { get; set; }

    public long? PrevContractId { get; set; }

    public long? ContractType { get; set; }

    public DateTime? SentDate { get; set; }

    public string? Recipient { get; set; }

    public string? ConsignmentDocumentNumber { get; set; }

    public bool? IsReceived { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public string? DocsComment { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
