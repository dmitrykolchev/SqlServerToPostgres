using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class EventCollaborators
{
    public long Id { get; set; }

    public long? EventId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? TypeId { get; set; }

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

    public bool? IsPublic { get; set; }

    public bool? IsOpen { get; set; }

    public bool? IsModel { get; set; }

    public long? DurationFact { get; set; }

    public long? CollaboratorId { get; set; }

    public long? EducationMethodId { get; set; }

    public string? PersonFullname { get; set; }

    public bool? IsCollaborator { get; set; }

    public bool? IsTutor { get; set; }

    public bool? IsPreparation { get; set; }

    public long? EventTypeId { get; set; }
}
