using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcStaffevalPgPerekrests
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public DateTime? Date { get; set; }

    public long? Instructor { get; set; }

    public long? InstructorGuest { get; set; }

    public string? Theme { get; set; }

    public long? BpId { get; set; }

    public long? ColsCategory { get; set; }

    public string? ChangeNumber { get; set; }

    public string? Mark { get; set; }

    public short? LearningAssessment { get; set; }

    public string? InstructorMark { get; set; }

    public string? GuestMark { get; set; }

    public long? SpRukId { get; set; }

    public string? SpId { get; set; }

    public DateTime? FactDate { get; set; }

    public string? Type { get; set; }

    public long? InsUtpDivision { get; set; }

    public long? GuestUtpDivision { get; set; }

    public string? Email { get; set; }

    public long? Responsible { get; set; }

    public string? VisitType { get; set; }

    public short? Ishappened { get; set; }

    public string? Programm { get; set; }

    public string? PollPdf { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public short? VisitorRating { get; set; }

    public DateTime? SendDateVisitorRating { get; set; }

    public short? SelfRating { get; set; }

    public DateTime? SendDateSelfRating { get; set; }

    public long? StationId { get; set; }
}
