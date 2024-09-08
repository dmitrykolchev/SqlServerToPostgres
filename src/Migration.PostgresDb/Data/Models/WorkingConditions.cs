using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class WorkingConditions
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

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

    public bool? IsModel { get; set; }

    public string? StateId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public long? ProbationaryDuration { get; set; }

    public string? PositionName { get; set; }

    public string? PlaceName { get; set; }

    public long? PlaceId { get; set; }

    public long? WorkingConditionTypeId { get; set; }

    public long? SalaryPaymentTypeId { get; set; }

    public long? WorkFormId { get; set; }

    public string? PaymentRemuneration { get; set; }

    public long? Salary { get; set; }

    public string? CurrencyTypeId { get; set; }

    public long? WorkScheduleTypeId { get; set; }

    public long? DailyDuration { get; set; }

    public long? WeeklyDuration { get; set; }

    public string? StartWorkType { get; set; }

    public string? StartWorkTime { get; set; }

    public string? EndWorkTime { get; set; }

    public double? LunchBreakDuration { get; set; }

    public string? LunchBreakType { get; set; }

    public string? StartLunchBreakTime { get; set; }

    public string? EndLunchBreakTime { get; set; }

    public long? ShiftsNumber { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
