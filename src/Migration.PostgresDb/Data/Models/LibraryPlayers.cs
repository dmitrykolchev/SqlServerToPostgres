using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class LibraryPlayers
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? LearningStorageId { get; set; }

    public long? ActivityId { get; set; }

    public bool? Cmi5 { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
