using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Licenses
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectName { get; set; }

    public string? ComputerName { get; set; }

    public string? DomainName { get; set; }

    public string? DomainShortName { get; set; }

    public string? UserName { get; set; }

    public bool? IsTemporary { get; set; }

    public string? StatusId { get; set; }

    public long? SaleContractId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public DateTime? MaintainceDate { get; set; }

    public long? UsersNum { get; set; }

    public bool? Demo { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
