using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class DnAcademDebts
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? FacultyId { get; set; }

    public long? ChairId { get; set; }

    public string? StateId { get; set; }

    public long? StreamId { get; set; }

    public long? StudGroupId { get; set; }

    public long? StudentId { get; set; }

    public long? DisciplId { get; set; }

    public long? ContrFormId { get; set; }

    public DateTime? LatestDate { get; set; }

    public DateTime? LiquidDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
