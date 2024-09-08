using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class EventGroups
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

    public long? GroupId { get; set; }
}
