using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcStaffevalFirstQuals
{
    public long Id { get; set; }

    public long? ParentId { get; set; }

    public long? Learning { get; set; }

    public long? Position { get; set; }

    public string? Category1 { get; set; }

    public string? Category2 { get; set; }

    public string? Location { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateFinish { get; set; }

    public long? Instructor { get; set; }

    public string? InstructorEmail { get; set; }

    public string? Type { get; set; }

    public long? CreatorId { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? LastEditorId { get; set; }

    public DateTime? LastEditDate { get; set; }

    public long? StationId { get; set; }

    public double? TheoreticalTraining { get; set; }

    public double? PracticalTraining { get; set; }

    public double? Internship { get; set; }

    public string? IppdDocument { get; set; }

    public string? OrderOnTraining { get; set; }

    public string? InternshipDocument { get; set; }

    public string? DuplicationDocument { get; set; }

    public string? ResponsibilitiesSubstitution { get; set; }

    public string? Admittance { get; set; }

    public short? LearningAssessment { get; set; }

    public string? Result { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
