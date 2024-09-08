using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class LibraryMaterialViewings
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? MaterialId { get; set; }

    public string? MaterialName { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? StateId { get; set; }

    public long? Duration { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? StartViewingDate { get; set; }

    public DateTime? LastViewingDate { get; set; }

    public DateTime? FinishViewingDate { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? CreationUserId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public long? ModificationUserId { get; set; }

    public string? AppInstanceId { get; set; }
}
