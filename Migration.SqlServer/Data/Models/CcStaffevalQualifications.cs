using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcStaffevalQualifications
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Requisites { get; set; }

    public long? Learning { get; set; }

    public long? Position { get; set; }

    public long? Division { get; set; }

    public long? Subdivision { get; set; }

    public string? TrainigPositions { get; set; }

    public long? MainPosition { get; set; }

    public string? Category1 { get; set; }

    public string? Category2 { get; set; }

    public long? OwnerOrganization { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateFinish { get; set; }

    public long? Instructor { get; set; }

    public string? Email { get; set; }

    public long? ResponsiblePerson { get; set; }

    public long? CreatorId { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? LastEditorId { get; set; }

    public DateTime? LastEditDate { get; set; }

    public long? StationId { get; set; }

    public double? TheoreticalTraining { get; set; }

    public double? PracticalTraining { get; set; }

    public double? Internship { get; set; }

    public string? AdditionalTraining { get; set; }

    public string? IppdDocument { get; set; }

    public string? PpdFile { get; set; }

    public string? OrderOnTraining { get; set; }

    public string? InternshipDocument { get; set; }

    public string? DuplicationDocument { get; set; }

    public string? Admittance { get; set; }

    public bool? LearningAssessment { get; set; }

    public string? Result { get; set; }

    public bool? InPlan { get; set; }

    public long? ResultId { get; set; }

    public string? OrganizationQuality { get; set; }

    public string? UmdSupply { get; set; }

    public string? UmdQuality { get; set; }

    public string? TsoSupply { get; set; }

    public string? ContentCompliance { get; set; }

    public string? EducationResult { get; set; }

    public string? Comments { get; set; }

    public string? Suggestions { get; set; }

    public long? Mark { get; set; }

    public bool? Permission { get; set; }

    public long? StatusQual { get; set; }

    public DateTime? AdmittanceDate { get; set; }

    public long? TotalTime { get; set; }

    public long? Poll { get; set; }

    public string? VerificationEvent { get; set; }

    public double? TimePercents { get; set; }

    public string? Location { get; set; }

    public string? Ppd { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
