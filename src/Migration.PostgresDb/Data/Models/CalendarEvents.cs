using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CalendarEvents
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public string? ObjectType { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

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

    public bool? IsException { get; set; }

    public string? InstanceCode { get; set; }

    public bool? IsDeleted { get; set; }

    public long? ParentId { get; set; }

    public long? PlaceId { get; set; }

    public long? RegionId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? PlanStartDate { get; set; }

    public DateTime? PlanEndDate { get; set; }

    public List<long>? ParticipantIds { get; set; }

    public List<long>? TutorIds { get; set; }

    public List<string>? SchedulerWeekDaysIds { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public string? SchedulerTypeId { get; set; }

    public string? WeekTypeId { get; set; }

    public List<long>? ConfirmParticipantIds { get; set; }

    public List<long>? NotParticipateParticipantIds { get; set; }

    public DateTime? NextStartDate { get; set; }

    public string? StateId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public DateTime? NotificationReminderDate { get; set; }
}
