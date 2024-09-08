using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Resumes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Sex { get; set; }

    public string? Email { get; set; }

    public string? FamilyStatus { get; set; }

    public DateTime? BirthDate { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonOrgName { get; set; }

    public string? PersonSubdivision { get; set; }

    public string? PersonPosition { get; set; }

    public long? CreatorPersonId { get; set; }

    public string? CreatorPersonFullname { get; set; }

    public bool? ForbidPortalDelete { get; set; }

    public string? FillingType { get; set; }

    public long? MinWage { get; set; }

    public long? MaxWage { get; set; }

    public string? CurrencyTypeId { get; set; }

    public long? ProfessionId { get; set; }

    public string? ProfessionAreaId { get; set; }

    public string? ProfessionArea { get; set; }

    public long? RegionId { get; set; }

    public string? EmploymentTypeId { get; set; }

    public string? ScheduleWorkId { get; set; }

    public long? ScheduleId { get; set; }

    public long? VacancySourceId { get; set; }

    public double? ExpYears { get; set; }

    public string? WillingnessTravelTypeId { get; set; }

    public bool? IsWillingRelocate { get; set; }

    public string? MainEducTypeId { get; set; }

    public string? Education { get; set; }

    public bool? IsArchive { get; set; }

    public bool? IsCandidate { get; set; }

    public List<string>? LngId { get; set; }

    public List<string>? EducTypeId { get; set; }

    public long? EducationTypeId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
