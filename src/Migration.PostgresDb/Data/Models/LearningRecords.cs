using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

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

    public string? PersonSubdivisionName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? StateId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public bool? IsFinishRecord { get; set; }

    public long? NumFailedCheckedFoto { get; set; }

    public string? CheckFotoStateId { get; set; }

    public bool? DownloadMaterials { get; set; }

    public string? ActiveSessionId { get; set; }

    public DateTime? ActiveSessionFinishDate { get; set; }

    public List<long>? ProctorsId { get; set; }

    public List<long>? ArchiveProctorsId { get; set; }

    public bool? IsPreferProctor { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
