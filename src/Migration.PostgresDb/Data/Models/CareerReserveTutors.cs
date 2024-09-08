using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CareerReserveTutors
{
    public long Id { get; set; }

    public long? CareerReserveId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? PlanReadinessDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public long? ReadinessPercent { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? TutorId { get; set; }

    public string? TutorType { get; set; }

    public bool? IsResponsible { get; set; }

    public string? TutorFullname { get; set; }
}
