using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Ratings
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? ObjectType { get; set; }

    public DateTime? Date { get; set; }

    public long? ExpertPersonId { get; set; }

    public string? ExpertPersonFullname { get; set; }

    public string? ExpertPersonPositionName { get; set; }

    public bool? Status { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
