using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Indicators
{
    public long Id { get; set; }

    public long? CompetenceId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? Type { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public List<long>? RoleId { get; set; }
}
