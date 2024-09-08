using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class LearningTasks
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public bool? YourselfStart { get; set; }

    public bool? UseInEvent { get; set; }

    public long? Duration { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public List<long>? ExpertsId { get; set; }

    public List<long>? RoleId { get; set; }

    public string? Tags { get; set; }

    public string? KnowledgeParts { get; set; }
}
