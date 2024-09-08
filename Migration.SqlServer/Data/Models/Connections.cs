using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Connections
{
    public long Id { get; set; }

    public long? CourseId { get; set; }

    public string? PartCode { get; set; }

    public string? UserId { get; set; }

    public string? UserFullname { get; set; }

    public long? ActiveLearningId { get; set; }

    public string? State { get; set; }

    public DateTime? CreationDate { get; set; }

    public bool? Unauthorized { get; set; }

    public DateTime? DeleteDate { get; set; }

    public string? LearningXml { get; set; }

    public string? HostPath { get; set; }
}
