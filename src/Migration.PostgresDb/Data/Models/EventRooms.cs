using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class EventRooms
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public string? TypeId { get; set; }

    public long? EventTypeId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? StatusId { get; set; }

    public long? PersonNum { get; set; }

    public long? UnnamedPersonNum { get; set; }

    public string? OrganizationalForm { get; set; }

    public long? EducationOrgId { get; set; }

    public string? EducationOrgName { get; set; }

    public double? TotalCost { get; set; }

    public string? Currency { get; set; }

    public bool? IsModel { get; set; }

    public bool? UseVclass { get; set; }

    public long? VclassSettingId { get; set; }

    public long? ConversationId { get; set; }

    public long? CompoundProgramId { get; set; }

    public long? EducationProgramId { get; set; }

    public long? EducationMethodId { get; set; }

    public long? CreateCompoundProgramId { get; set; }

    public long? PlaceId { get; set; }

    public string? VclassHost { get; set; }

    public bool? RecordExists { get; set; }

    public bool? ShowRecord { get; set; }

    public long? ParentEventId { get; set; }

    public long? CourseFinished { get; set; }

    public long? CourseProcess { get; set; }

    public long? CourseStarted { get; set; }

    public long? CourseBegan { get; set; }

    public long? TestFinished { get; set; }

    public long? TestProcess { get; set; }

    public long? TestStarted { get; set; }

    public long? TestBegan { get; set; }

    public bool? GroupFormed { get; set; }

    public long? CourseId { get; set; }

    public long? TrainingPlanId { get; set; }

    public bool? IsPublic { get; set; }

    public bool? IsOpen { get; set; }

    public double? Cost { get; set; }

    public string? CostType { get; set; }

    public long? BudgetPeriodId { get; set; }

    public string? DistributeCostType { get; set; }

    public double? DurationFact { get; set; }

    public double? DurationDaysFact { get; set; }

    public bool? MandatoryFillResponse { get; set; }

    public string? EventForm { get; set; }

    public long? SubdivisionId { get; set; }

    public long? OrgId { get; set; }

    public string? SendType { get; set; }

    public string? SendPersonsTypes { get; set; }

    public string? GroupEducGroupId { get; set; }

    public long? WebinarSystemId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public string? TutorMain { get; set; }

    public long? PollId { get; set; }

    public List<long>? RoleId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
