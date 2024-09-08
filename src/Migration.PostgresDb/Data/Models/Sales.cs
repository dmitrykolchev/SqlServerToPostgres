using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Sales
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public long? StatusId { get; set; }

    public string? Number { get; set; }

    public long? OrgId { get; set; }

    public long? ClientOrgId { get; set; }

    public long? ProjectId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public long? ClientManagerId { get; set; }

    public long? ManagerId { get; set; }

    public long? Cost { get; set; }

    public string? CurrencyTypeId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
