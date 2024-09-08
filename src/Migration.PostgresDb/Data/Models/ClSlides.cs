using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ClSlides
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ClCourseId { get; set; }

    public long? ClModuleId { get; set; }

    public long? MasterId { get; set; }

    public string? MasterCode { get; set; }

    public bool? IsMaster { get; set; }

    public bool? IsSplash { get; set; }

    public long? Sid { get; set; }

    public string? FlagLocked { get; set; }

    public long? GreedyPersonId { get; set; }

    public string? GreedyPersonFullname { get; set; }

    public bool? FlagCompletion { get; set; }

    public long? ApprovalStatus { get; set; }

    public long? Stamp { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
