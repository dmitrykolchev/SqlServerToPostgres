using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcStaffevalPpdCas
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Requisites { get; set; }

    public string? Category1 { get; set; }

    public string? Category2 { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? LastChangeDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? StructurDivision { get; set; }

    public long? InstructorId { get; set; }

    public long? ResponsiblePerson { get; set; }

    public long? OwnerOrganization { get; set; }

    public long? StatusId { get; set; }

    public string? Npp { get; set; }

    public double? Mark { get; set; }

    public DateTime? FirstDate { get; set; }

    public long? CreatorId { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? LastEditorId { get; set; }

    public DateTime? EditDate { get; set; }

    public short? InPlan { get; set; }

    public long? Agent1 { get; set; }

    public DateTime? LastSendDate1 { get; set; }

    public long? Agent2 { get; set; }

    public DateTime? LastSendDate2 { get; set; }

    public long? Agent3 { get; set; }

    public DateTime? LastSendDate3 { get; set; }

    public long? Agent4 { get; set; }

    public DateTime? LastSendDate4 { get; set; }

    public string? ExternalUrl { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
