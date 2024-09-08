using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class EventLectors
{
    public long Id { get; set; }

    public long? EventId { get; set; }

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

    public long? PlaceId { get; set; }

    public long? LectorId { get; set; }

    public string? Type { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? LectorFullname { get; set; }

    public long? Hours { get; set; }

    public bool? IsTutor { get; set; }

    public bool? IsCollaborator { get; set; }

    public bool? IsPreparation { get; set; }
}
