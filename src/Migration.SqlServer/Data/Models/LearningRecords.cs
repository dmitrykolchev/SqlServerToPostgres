using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class LearningRecords
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? ObjectType { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public long? EventId { get; set; }

    public string? ProctoringObjectType { get; set; }

    public long? ProctoringObjectId { get; set; }

    public string? ProctoringObjectName { get; set; }

    public long? ProctoringSystemId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonPositionName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? StateId { get; set; }

    public DateTime? FinishDate { get; set; }

    public bool? IsFinishRecord { get; set; }

    public bool? DownloadMaterials { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
