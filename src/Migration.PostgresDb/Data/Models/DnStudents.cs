using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class DnStudents
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Type { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Region { get; set; }

    public string? AdressFactLive { get; set; }

    public long? SpecialId { get; set; }

    public long? SpecializationId { get; set; }

    public string? EducatFormId { get; set; }

    public string? EduConditionId { get; set; }

    public long? QualificationId { get; set; }

    public string? StatusId { get; set; }

    public long? MainGroupId { get; set; }

    public string? EducatGroups { get; set; }

    public string? StudDtId { get; set; }

    public string? EducatInstitution { get; set; }

    public bool? IsExcellent { get; set; }

    public long? FacultyId { get; set; }

    public long? ChairId { get; set; }

    public long? ScientAdviserId { get; set; }

    public string? Subject { get; set; }

    public string? FileName { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
