using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Subscriptions
{
    public long Id { get; set; }

    public string? Type { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? DateTo { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonOrgName { get; set; }

    public long? DocumentId { get; set; }

    public bool? IncludeSubdocs { get; set; }

    public DateTime? DateLastAction { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
