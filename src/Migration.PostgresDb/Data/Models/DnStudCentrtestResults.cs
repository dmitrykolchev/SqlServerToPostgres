using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class DnStudCentrtestResults
{
    public long Id { get; set; }

    public string? Subject { get; set; }

    public long? Mark { get; set; }

    public DateTime? ResultDate { get; set; }

    public long? StudentId { get; set; }

    public string? StudentFullname { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
