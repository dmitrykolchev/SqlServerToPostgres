using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Transactions
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public DateTime? Date { get; set; }

    public long? Direction { get; set; }

    public long? OrgId { get; set; }

    public double? Amount { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public long? AccountId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? Objects { get; set; }
}
