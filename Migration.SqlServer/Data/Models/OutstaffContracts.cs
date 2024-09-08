using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class OutstaffContracts
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public DateTime? Date { get; set; }

    public string? Status { get; set; }

    public string? TypeId { get; set; }

    public string? Number { get; set; }

    public long? ContractTypeId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public long? OutstaffProviderId { get; set; }

    public string? DispName { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
