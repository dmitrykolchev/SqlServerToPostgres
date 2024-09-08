using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcStaffevalFirstDocuments
{
    public long Id { get; set; }

    public long? Parent { get; set; }

    public string? Name { get; set; }

    public string? Requisites { get; set; }

    public long? Division { get; set; }

    public long? Subdivision { get; set; }

    public string? Category1 { get; set; }

    public string? Category2 { get; set; }

    public double? Time { get; set; }

    public long? Position { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? StructurDivision { get; set; }

    public long? InstructorId { get; set; }

    public long? OwnerOrganization { get; set; }

    public long? PlacementOrganization { get; set; }

    public long? StatusId { get; set; }

    public double? Mark { get; set; }

    public DateTime? FirstDate { get; set; }

    public long? CreatorId { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? LastEditorId { get; set; }

    public DateTime? EditDate { get; set; }

    public long? StationId { get; set; }

    public long? Code { get; set; }

    public bool? DocumentProcessed { get; set; }

    public long? ParentId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
