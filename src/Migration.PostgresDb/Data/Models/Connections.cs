using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Connections
{
    public long Id { get; set; }

    public long? CourseId { get; set; }

    public string? PartCode { get; set; }

    public long? UserId { get; set; }

    public string? UserCode { get; set; }

    public string? UserFullname { get; set; }

    public long? ActiveLearningId { get; set; }

    public string? LearningXml { get; set; }

    public string? State { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? DeleteDate { get; set; }

    public DateTime? TerminateDate { get; set; }

    public bool? Unauthorized { get; set; }

    public string? HostPath { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
