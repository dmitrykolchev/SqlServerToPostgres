using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class SelectedResumes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? ResumeId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
