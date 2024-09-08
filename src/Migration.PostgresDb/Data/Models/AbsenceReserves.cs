using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class AbsenceReserves
{
    public long Id { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? PersonPositionId { get; set; }

    public string? PersonPositionName { get; set; }

    public string? PersonPositionCode { get; set; }

    public long? PersonOrgId { get; set; }

    public string? PersonOrgName { get; set; }

    public string? PersonOrgCode { get; set; }

    public long? PersonSubdivisionId { get; set; }

    public string? PersonSubdivisionName { get; set; }

    public string? PersonSubdivisionCode { get; set; }

    public string? PersonInstanceId { get; set; }

    public string? PersonCode { get; set; }

    public long? BudgetPeriodId { get; set; }

    public long? PresenceStateId { get; set; }

    public long? NumDays { get; set; }

    public DateTime? CalculationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
