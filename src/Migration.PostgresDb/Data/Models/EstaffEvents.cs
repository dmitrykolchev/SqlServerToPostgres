using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class EstaffEvents
{
    public long Id { get; set; }

    public string? CodeEvent { get; set; }

    public string? EventName { get; set; }

    public DateTime? StartDate { get; set; }

    public long? VacancyId { get; set; }

    public string? VacancyName { get; set; }

    public string? VacancyCode { get; set; }

    public long? RequestId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? EstaffEventTypeId { get; set; }

    public string? EstaffEventTypeName { get; set; }

    public string? ObjectType { get; set; }

    public string? Objects { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public string? LinkedObjectUrl { get; set; }

    public string? EventStatusId { get; set; }

    public long? EstaffEventEid { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
