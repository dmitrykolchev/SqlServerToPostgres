using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Invoices
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public DateTime? Date { get; set; }

    public bool? IsPaid { get; set; }

    public double? Amount { get; set; }

    public long? OrgId { get; set; }

    public long? RequestId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
