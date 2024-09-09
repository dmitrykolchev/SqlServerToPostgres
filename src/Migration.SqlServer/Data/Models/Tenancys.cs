using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Tenancys
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? CreatorId { get; set; }

    public string? CreatorFullname { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public long? OrgId { get; set; }

    public string? OrgName { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public DateTime? LastUsageDate { get; set; }
}
